using HemSokClient.Data;
using HemSokClient.Models.LoginModels;
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
            if (apiService != null && apiService.currentUser != null )
            {
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", apiService.currentUser.loginResponse.JwtToken);
            }
            else
            {
                Console.WriteLine("apiService or apiService.currentUser is null");
            }
            
            var jwt = apiService.JwtSession;                  
            if (!string.IsNullOrEmpty(jwt))
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", jwt);
                
            return await base.SendAsync(request, cancellationToken);
        }
    }
}
