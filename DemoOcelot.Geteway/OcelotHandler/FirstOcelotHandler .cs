using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace DemoOcelot.Geteway.OcelotHandler
{
    public class FirstOcelotHandler : DelegatingHandler
    {
        private readonly ILogger<FirstOcelotHandler> _logger;
        public FirstOcelotHandler(ILogger<FirstOcelotHandler> logger)
        {
            _logger = logger;
        }
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("FirstOcelotHandler");
            //do stuff and optionally call the base handler..
            return await base.SendAsync(request, cancellationToken);
        }
    }
}
