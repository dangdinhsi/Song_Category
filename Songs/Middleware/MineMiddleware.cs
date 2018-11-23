using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Songs.Middleware
{
    public class MineMiddleware
    {
        private readonly RequestDelegate _next;

        public MineMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (context.Request.Headers.ContainsKey("Authorization"))
            {   
                var basicToken = context.Request.Headers["Authorization"].ToString();
                basicToken = basicToken.Replace("Basic ", "");
            }
            else
            {
                context.Response.StatusCode = 403;
                await context.Response.WriteAsync("MVC didn't ....");
            }
        }
    }
}
