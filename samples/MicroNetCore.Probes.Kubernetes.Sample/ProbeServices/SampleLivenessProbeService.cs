using System.Threading.Tasks;

namespace MicroNetCore.Probes.Kubernetes.Sample.ProbeServices
{
    public sealed class SampleLivenessProbeService : ILivenessProbeService
    {
        public Task<bool> ProbeAsync() => Task.FromResult(true);
    }
}