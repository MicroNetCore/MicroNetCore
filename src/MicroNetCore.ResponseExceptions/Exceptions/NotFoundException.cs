using System.Net;

namespace MicroNetCore.ResponseExceptions.Exceptions
{
    public sealed class NotFoundException : ResponseException
    {
        public override HttpStatusCode HttpStatusCode => HttpStatusCode.NotFound;
    }
}