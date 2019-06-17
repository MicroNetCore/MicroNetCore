using System.Threading.Tasks;

namespace MicroNetCore.Probes
{
    public interface IProbeService
    {
        Task<bool> ProbeAsync();
    }
}