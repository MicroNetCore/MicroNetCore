using System;
using System.Net;

namespace MicroNetCore.ResponseExceptions
{
    public abstract class ResponseException : Exception
    {
        public abstract HttpStatusCode HttpStatusCode { get; }
    }
}