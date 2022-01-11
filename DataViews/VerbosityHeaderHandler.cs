using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace DataViews
{
    public class VerbosityHeaderHandler : DelegatingHandler
    {
        // public bool Verbose { get; set; }
        private readonly bool _verbose;

        public VerbosityHeaderHandler(bool verbose = true)
        {
            _verbose = verbose;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            if (!_verbose)
            {
                request?.Headers.Add("accept-verbosity", "non-verbose");
            }

            return await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
        }
    }
}
