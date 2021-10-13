using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;

namespace ZeroXTeam.Helpers
{
    public static class NotFoundMiddleware
    {
        public static void UseNotFoundError(this IApplicationBuilder applicationBuilder)
        {
            applicationBuilder.Use(async (context, next) =>
                {
                    await next();
                    if (context.Response.StatusCode == 404)
                    {
                        context.Request.Path = "/not-found";
                        await next();
                    }
                });
        }
    }
}