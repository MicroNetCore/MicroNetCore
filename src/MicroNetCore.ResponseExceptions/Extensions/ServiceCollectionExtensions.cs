using MicroNetCore.ResponseExceptions.Middleware;
using Microsoft.Extensions.DependencyInjection;

namespace MicroNetCore.ResponseExceptions.Extensions
{
    public static class ServiceCollectionExtensions
    {
        // TODO: Review service scope
        public static IServiceCollection AddResponseExceptions(this IServiceCollection services) =>
            services.AddTransient<ResponseExceptionMiddleware>();
    }
}