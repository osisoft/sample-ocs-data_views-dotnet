using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace DataViews
{
    public class VerbosityHeaderHandler : DelegatingHandler
    {
        
        public VerbosityHeaderHandler(bool verbose = true)
        {
            Verbose = verbose;
        }

        public bool Verbose { get; set; }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            if (!Verbose)
            {
                request?.Headers.Add("accept-verbosity", "non-verbose");
            }

            return await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
        }
    }
}
