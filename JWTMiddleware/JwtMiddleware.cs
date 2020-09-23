using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using NewCity.Common;
using NewCity.DataAccess.Model;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace JWTMiddleware
{
    public class JwtMiddleware
    {
        private readonly RequestDelegate _next;
        //private readonly IConfiguration _configuration;

        private const string _Issuer = "NC";
        private const string _SignKey = "624ec7d357cc31debffbfa5064f1bb52e6ef102270efa126d68385bf9096b1cb";


        public JwtMiddleware(RequestDelegate next)
        {
            _next = next;
            //_configuration = configuration;
        }

        public async Task Invoke(HttpContext context)
        {
            var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

            if (string.IsNullOrEmpty(token))
            {
                // Note : 不用 jwt 驗證時的寫法 (預留) 先不處理，之後加上 access token 的方式檢查
                context.Response.StatusCode = 401;
                context.Response.ContentType = "application/json";
                string response = JsonSerializer.Serialize(JWTErrorStruct.ErrorNum.token_invalid.JWTGetErrReturn());
                await context.Response.WriteAsync(response);

                return;
            }
            else
            {
                try
                {
                    new JwtSecurityTokenHandler().ValidateToken(token, new TokenValidationParameters
                    {
                        // 驗證 Issuer
                        ValidateIssuer = true,
                        //封裝成middleware library後改讀程式碼內部設定值
                        //ValidIssuer = _configuration.GetValue<string>("JwtSettings:Issuer"),
                        ValidIssuer = _Issuer,
                        // 取消驗證 Audience
                        ValidateAudience = false,
                         
                        // 驗證 Token 的有效期間
                        ValidateLifetime = true,

                        // 驗證 Token 中的 key
                        ValidateIssuerSigningKey = true,
                        //封裝成middleware library後改讀程式碼內部設定值
                        //IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetValue<string>("JwtSettings:SignKey")))
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_SignKey))
                    }, out SecurityToken securityToken);

                    // Notde : Here can be validate user permission. If user has no permission then throws exception
                    // pass tokenUserInfo to next
                    context.Items["TokenUserInfo"] = JsonSerializer.Deserialize<TokenUserInfo>(((JwtSecurityToken)securityToken).Payload["permissions"].ToString());
                }
                catch (SecurityTokenExpiredException steex)
                {
                    NCLog.ExceptionLog(steex, $"Token={token}");

                    context.Response.StatusCode = 401;
                    context.Response.ContentType = "application/json";

                    string response = JsonSerializer.Serialize(JWTErrorStruct.ErrorNum.token_expired.JWTGetErrReturn(steex.Message));
                    await context.Response.WriteAsync(response);

                    return;
                }
                catch (SecurityTokenValidationException stvex)
                {
                    NCLog.ExceptionLog(stvex, $"Token={token}");

                    context.Response.StatusCode = 401;
                    context.Response.ContentType = "application/json";

                    string response = JsonSerializer.Serialize(JWTErrorStruct.ErrorNum.token_invalid.JWTGetErrReturn(stvex.Message));
                    await context.Response.WriteAsync(response);

                    return;
                }
                catch (Exception ex)
                {
                    NCLog.ExceptionLog(ex, $"Token={token}");

                    context.Response.StatusCode = 401;
                    context.Response.ContentType = "application/json";

                    string response = JsonSerializer.Serialize(JWTErrorStruct.ErrorNum.error_undefined.JWTGetErrReturn(ex.Message));
                    await context.Response.WriteAsync(response);

                    return;
                }
            }

            await _next(context);
        }
    }

    public static class JwtMiddlewareExtensions
    {
        public static IApplicationBuilder UseNCJwtMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<JwtMiddleware>();
        }
    }
}
