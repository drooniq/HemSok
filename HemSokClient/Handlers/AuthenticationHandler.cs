using HemSokClient.Data;
using System.Net.Http.Headers;
/*
 Author: Marcus Karlsson
 */
namespace HemSokClient.Handlers
{
    public class AuthenticationHandler : DelegatingHandler
    {
        private readonly IAPIService apiService;
        private readonly IConfiguration config;

        public AuthenticationHandler(IAPIService apiService, IConfiguration config)
        {
            this.apiService = apiService;
            this.config = config;
        }
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            //if (apiService.currentUser ==null)
            //{
            //    return await base.SendAsync(request, cancellationToken);
            //}

            var jwt = apiService.JwtSession;                  
            if (!string.IsNullOrEmpty(jwt))
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", jwt);
                
            return await base.SendAsync(request, cancellationToken);
        }
    }
}
