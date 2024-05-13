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
        public CurrentUser? currentUser { get; set; } = null;
        public List<Agency>? Agencies { get; set; }
        public List<Agent>? Agents { get; set; }
        public List<Category>? Categories { get; set; }
        public List<County>? Counties { get; set; }
        public List<Municipality>? Municipality { get; set; }
        public List<Residence>? Residences { get; set; }

        public APIService(IHttpClientFactory factory)
        {
            this.Factory = factory;         
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

        public async Task<bool> LoginAsync(LoginModel model)
        {
            var response = await Factory.CreateClient("CustomClient")
                                        .PostAsync("api/account/login", JsonContent.Create(model));

            if (!response.IsSuccessStatusCode)
                throw new UnauthorizedAccessException("Login failed.");

            var content = await response.Content.ReadFromJsonAsync<LoginResponse>();

            if (content == null)
                throw new InvalidDataException();
            //JwtSession = content.JwtToken;         
            //var agents = await GetAllFromApiAsync<Agent>();
            var jwt = new JwtSecurityToken(content.JwtToken);
            currentUser = new CurrentUser 
            {
               AgentId = content.Id,
               Role = jwt.Claims.First(s => s.Type == ClaimTypes.Role).Value,
               loginResponse = content
             };
            return currentUser is not null;
        }
        public void Logout()
        {
            if (currentUser != null)
            {
                currentUser = null;
            }        
        }
        public async Task<bool> RegisterAsync(RegisterModel model)
        {                                         
            var response = await  Factory.CreateClient("CustomClient")                                     
                                        .PostAsync("api/account/register", JsonContent.Create(model));
            return response.IsSuccessStatusCode;
        }
    }
}
