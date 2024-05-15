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
        private readonly IConfiguration config;
        private readonly IAuthStateService authStateService;

        public AuthenticationHandler(IConfiguration config, IAuthStateService authStateService)
        {     
            this.config = config;
            this.authStateService = authStateService;
        }
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (authStateService != null && authStateService.currentUser != null )
            {
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", authStateService.currentUser.loginResponse.JwtToken);
            }
            else
            {
                Console.WriteLine("apiService or apiService.currentUser is null");
            }

            return await base.SendAsync(request, cancellationToken);
        }
    }
}
