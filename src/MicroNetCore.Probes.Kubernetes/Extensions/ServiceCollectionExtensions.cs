using Microsoft.Extensions.DependencyInjection;

namespace MicroNetCore.Probes.Kubernetes.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddLivenessProbeService<TProbeService>(this IServiceCollection services)
            where TProbeService : class, ILivenessProbeService
        {
            services.AddSingleton<ILivenessProbeService, TProbeService>();

            return services;
        }

        public static IServiceCollection AddReadinessProbeService<TProbeService>(this IServiceCollection services)
            where TProbeService : class, IReadinessProbeService
        {
            services.AddSingleton<IReadinessProbeService, TProbeService>();

            return services;
        }
    }
}