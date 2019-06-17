namespace MicroNetCore.Probes.Kubernetes
{
    public static class Paths
    {
        public const string Liveness = "/api/alive";
        public const string Readiness = "/api/ready";
    }
}