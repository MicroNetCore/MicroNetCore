using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace MicroNetCore.ResponseExceptions.Middleware
{
    public sealed class ResponseExceptionMiddleware : IMiddleware
    {
        private readonly ILogger<ResponseExceptionMiddleware> _logger;

        public ResponseExceptionMiddleware(ILoggerFactory loggerFactory) =>
            _logger = loggerFactory.CreateLogger<ResponseExceptionMiddleware>();

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (Exception e)
            {
                _logger.LogError(e.ToString());

                // TODO: Add check for Response.HasStarted
                context.Response.StatusCode = (int) GetStatusCode(e);
            }
        }

        private static HttpStatusCode GetStatusCode(Exception e)
        {
            if (e is ResponseException responseException)
                return responseException.HttpStatusCode;

            return HttpStatusCode.InternalServerError;
        }
    }
}