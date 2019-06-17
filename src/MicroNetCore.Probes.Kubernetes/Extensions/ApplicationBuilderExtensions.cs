using Microsoft.AspNetCore.Builder;

namespace MicroNetCore.Probes.Kubernetes.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseKubernetesHttpLivenessEndpoint(this IApplicationBuilder app,
            string path = Paths.Liveness)
        {
            app.UseMiddleware<HttpProbeMiddleware<ILivenessProbeService>>(path);

            return app;
        }

        public static IApplicationBuilder UseKubernetesHttpReadinessEndpoint(this IApplicationBuilder app,
            string path = Paths.Readiness)
        {
            app.UseMiddleware<HttpProbeMiddleware<IReadinessProbeService>>(path);

            return app;
        }
    }
}