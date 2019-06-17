using System.Threading.Tasks;

namespace MicroNetCore.Probes.Core
{
    public interface IProbeService
    {
        Task<bool> ProbeAsync();
    }
}