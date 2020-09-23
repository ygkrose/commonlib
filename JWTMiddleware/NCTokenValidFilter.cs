using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace JWTMiddleware
{
    /// <summary>
    /// Token Filter
    /// </summary>
    public class NCTokenValidFilter : ActionFilterAttribute
    {
        public override Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (context.HttpContext.Items["TokenUserInfo"] == null)
            {
                context.HttpContext.Response.StatusCode = 401;
                context.HttpContext.Response.ContentType = "application/json";
                string response = JsonSerializer.Serialize(JWTErrorStruct.ErrorNum.token_invalid.JWTGetErrReturn());
                return context.HttpContext.Response.WriteAsync(response);
            }
            return base.OnActionExecutionAsync(context, next);
        }

    }
}
