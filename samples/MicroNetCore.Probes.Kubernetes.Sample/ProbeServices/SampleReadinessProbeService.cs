using System.Threading.Tasks;

namespace MicroNetCore.Probes.Kubernetes.Sample.ProbeServices
{
    public sealed class SampleReadinessProbeService : IReadinessProbeService
    {
        public Task<bool> ProbeAsync() => Task.FromResult(true);
    }
}