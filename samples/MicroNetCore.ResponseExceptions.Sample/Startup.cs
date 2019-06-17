using MicroNetCore.ResponseExceptions.Exceptions;
using MicroNetCore.ResponseExceptions.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace MicroNetCore.ResponseExceptions.Sample
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services) =>
            services.AddResponseExceptions();

        public void Configure(IApplicationBuilder app, IHostingEnvironment env) =>
            app.UseResponseExceptions().Run(context => throw new NotFoundException());
    }
}