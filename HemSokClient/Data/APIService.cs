using HemSokClient.Models;
using HemSokClient.Models.LoginModels;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Security.Claims;

/*
 author: Emil Waara, Marcus Karlsson
 */
namespace HemSokClient.Data
{
    public class APIService : IAPIService
    {

        private readonly IHttpClientFactory Factory;
        private readonly IAuthStateService authStateService;
        public List<Agency>? Agencies { get; set; }
        public List<Agent>? Agents { get; set; }
        public List<Category>? Categories { get; set; }
        public List<County>? Counties { get; set; }
        public List<Municipality>? Municipality { get; set; }
        public List<Residence>? Residences { get; set; }

        public APIService(IHttpClientFactory factory, IAuthStateService authStateService)
        {
            this.Factory = factory;
            this.authStateService = authStateService;
        }

        // string uri = "api/Residence/" + residence.Id;
        public async Task<bool> DeleteFromApiAsync<T>(string uri, T modelData) where T : class
        {
            var response = await Factory.CreateClient("CustomClient")
                                        .DeleteAsync(uri);
            return response.IsSuccessStatusCode;
        }

        // string uri = "api/Residence/" + residence.Id;
        public async Task<T?> GetFromApiAsync<T>(string uri) where T : class
        {
            var response = await Factory.CreateClient("CustomClient")
                                        .GetAsync(uri);
            T? modelData = response.IsSuccessStatusCode ? await response.Content.ReadFromJsonAsync<T>() : null;
            return modelData;
        }

        // var lista = await GetAllFromApiAsync<Residence>();
        public async Task<List<T>?> GetAllFromApiAsync<T>() where T : class
        {
            var response = await Factory.CreateClient("CustomClient")
                                        .GetAsync("api/" + typeof(T).Name);
            List<T>? modelData = response.IsSuccessStatusCode ? await response.Content.ReadFromJsonAsync<List<T>>() : null;
            return modelData;
        }

        // skapa ny bostad
        public async Task<bool> PostToApiAsync<T>(T modelData) where T : class
        {
            var response = await Factory.CreateClient("CustomClient")
                                        .PostAsJsonAsync("api/" + typeof(T).Name, modelData);
            return response.IsSuccessStatusCode;
        }

        // string uri = "api/" + typeof(T).Name, modelData   modelData = den förändrade residence 
        public async Task<bool> PutToApiAsync<T>(T modelData) where T : class
        {
            var response = await Factory.CreateClient("CustomClient")
                                        .PutAsJsonAsync("api/" + typeof(T).Name, modelData);
            return response.IsSuccessStatusCode;
        }

        // Login logik för api
        public async Task<CurrentUser> LoginAsync(LoginModel model)
        {
            var response = await Factory.CreateClient("CustomClient")
                                        .PostAsync("api/account/login", JsonContent.Create(model));
            
            Console.WriteLine(response.ToString());
            
            if (!response.IsSuccessStatusCode)
                throw new UnauthorizedAccessException("Login failed.");

            var content = await response.Content.ReadFromJsonAsync<LoginResponse>();

            if (content == null)
                throw new InvalidDataException();        
            
            var agent = await GetFromApiAsync<Agent>("/api/agent/" + content.Id);

            var jwt = new JwtSecurityToken(content.JwtToken);
            authStateService.Login( new CurrentUser
            {
                AgentId = content.Id,
                Role = jwt.Claims.First(s => s.Type == ClaimTypes.Role).Value,
                loginResponse = content,
                AgencyId = agent.Agency.Id
             });
            return authStateService.currentUser;
        }      
        public async Task<bool> RegisterAsync(RegisterModel model)
        {                                         
            var response = await  Factory.CreateClient("CustomClient")                                     
                                        .PostAsync("api/account/register", JsonContent.Create(model));
            return response.IsSuccessStatusCode;
        }
    }
}
