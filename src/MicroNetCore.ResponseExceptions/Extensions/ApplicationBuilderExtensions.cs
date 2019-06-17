using MicroNetCore.ResponseExceptions.Middleware;
using Microsoft.AspNetCore.Builder;

namespace MicroNetCore.ResponseExceptions.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseResponseExceptions(this IApplicationBuilder app) =>
            app.UseMiddleware<ResponseExceptionMiddleware>();
    }
}