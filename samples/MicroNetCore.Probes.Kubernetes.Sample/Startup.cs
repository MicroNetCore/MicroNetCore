using MicroNetCore.Probes.Kubernetes.Extensions;
using MicroNetCore.Probes.Kubernetes.Sample.ProbeServices;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace MicroNetCore.Probes.Kubernetes.Sample
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddLivenessProbeService<SampleLivenessProbeService>();
            services.AddReadinessProbeService<SampleReadinessProbeService>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            // Add readiness probes endpoint
            app.UseKubernetesHttpReadinessEndpoint();

            // Add liveness probes endpoint
            app.UseKubernetesHttpLivenessEndpoint();

            app.Run(async context => { await context.Response.WriteAsync("Hello World!"); });
        }
    }
}