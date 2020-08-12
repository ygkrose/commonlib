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
        private readonly IConfiguration _configuration;

        public JwtMiddleware(RequestDelegate next, IConfiguration configuration)
        {
            _next = next;
            _configuration = configuration;
        }

        public async Task Invoke(HttpContext context)
        {
            var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

            if (string.IsNullOrEmpty(token))
            {
                // Note : 不用 jwt 驗證時的寫法 (預留) 先不處理，之後加上 access token 的方式檢查
                //context.Response.StatusCode = 401;
                //context.Response.ContentType = "application/json";

                //await context.Response.WriteAsync(new JObject
                //{
                //    ["ErrorCode"] = "100900",
                //    ["ErrorMessage"] = "AuthenticationFailed", // ["ErrorMessage"] = ex.Message.ToString(),
                //    ["ErrorTime"] = DateTime.Now
                //}.ToString());

                //return;
            }
            else
            {
                try
                {
                    new JwtSecurityTokenHandler().ValidateToken(token, new TokenValidationParameters
                    {
                        // 驗證 Issuer
                        ValidateIssuer = true,
                        ValidIssuer = _configuration.GetValue<string>("JwtSettings:Issuer"),

                        // 取消驗證 Audience
                        ValidateAudience = false,

                        // 驗證 Token 的有效期間
                        ValidateLifetime = true,

                        // 驗證 Token 中的 key
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetValue<string>("JwtSettings:SignKey")))

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

                    string response = JsonSerializer.Serialize(ErrorStruct.ErrorNum.token_expired.GetErrReturn(steex.Message));
                    await context.Response.WriteAsync(response);

                    return;
                }
                catch (SecurityTokenValidationException stvex)
                {
                    NCLog.ExceptionLog(stvex, $"Token={token}");

                    context.Response.StatusCode = 401;
                    context.Response.ContentType = "application/json";

                    string response = JsonSerializer.Serialize(ErrorStruct.ErrorNum.token_invalid.GetErrReturn(stvex.Message));
                    await context.Response.WriteAsync(response);

                    return;
                }
                catch (Exception ex)
                {
                    NCLog.ExceptionLog(ex, $"Token={token}");

                    context.Response.StatusCode = 401;
                    context.Response.ContentType = "application/json";

                    string response = JsonSerializer.Serialize(ErrorStruct.ErrorNum.error_undefined.GetErrReturn(ex.Message));
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
