using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace DemoOcelot.FirstService.Middleware
{
    public class DefaultMiddleware
    {
        private readonly ILogger<DefaultMiddleware> _logger;
        private readonly RequestDelegate _dequestDelegate;
        public DefaultMiddleware(ILogger<DefaultMiddleware> logger,
            RequestDelegate requestDelegate)
        {
            _logger = logger;
            _dequestDelegate = requestDelegate;
        }
        public async Task Invoke(HttpContext context)
        {
            foreach (var key in context.Request.Headers.Keys)
            {
                _logger.LogInformation($"[{ key }]:[{ context.Request.Headers[key] }]");
            }
            await _dequestDelegate(context);
        }
    }
}
