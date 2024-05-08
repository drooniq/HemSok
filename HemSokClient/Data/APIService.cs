using HemSokClient.Models;
using HemSokClient.Models.LoginModels;
using System;
using System.Net.Http;
using System.Net.Http.Json;

/*
 author: Emil Waara
 */
namespace HemSokClient.Data
{
    public class APIService : IAPIService
    {
        public HttpClient Client { get; set; }

        public List<Agency>? Agencies { get; set; }
        public List<Agent>? Agents { get; set; }
        public List<Category>? Categories { get; set; }
        public List<County>? Counties { get; set; }
        public List<Municipality>? Municipality { get; set; }
        public List<Residence>? Residences { get; set; }
        public LoginResponse LoginResponse { get; set; }

        public APIService(HttpClient Client)
        {
            this.Client = Client;
        }

        // string uri = "api/Residence/" + residence.Id;
        public async Task<bool> DeleteFromApiAsync<T>(string uri, T modelData) where T : class
        {
            var response = await Client.DeleteAsync(uri);
            return response.IsSuccessStatusCode;
        }

        // string uri = "api/Residence/" + residence.Id;
        public async Task<T?> GetFromApiAsync<T>(string uri) where T : class
        {
            var response = await Client.GetAsync(uri);
            T? modelData = response.IsSuccessStatusCode ? await response.Content.ReadFromJsonAsync<T>() : null;
            return modelData;
        }

        // var lista = await GetAllFromApiAsync<Residence>();
        public async Task<List<T>?> GetAllFromApiAsync<T>() where T : class
        {
            var response = await Client.GetAsync("api/" + typeof(T).Name);
            List<T>? modelData = response.IsSuccessStatusCode ? await response.Content.ReadFromJsonAsync<List<T>>() : null;
            return modelData;
        }

        // skapa ny bostad
        public async Task<bool> PostToApiAsync<T>(T modelData) where T : class
        {
            var response = await Client.PostAsJsonAsync("api/" + typeof(T).Name, modelData);
            return response.IsSuccessStatusCode;
        }

        // string uri = "api/" + typeof(T).Name, modelData   modelData = den förändrade residence 
        public async Task<bool> PutToApiAsync<T>(T modelData) where T : class
        {
            var response = await Client.PutAsJsonAsync("api/" + typeof(T).Name, modelData);
            return response.IsSuccessStatusCode;
        }

        // Login logik för api

        public async Task<DateTime> LoginAsync(LoginModel model)
        {
            var response = await Client.PostAsync("api/account/login", JsonContent.Create(model));
            if (!response.IsSuccessStatusCode)
                throw new UnauthorizedAccessException("Login failed.");
            var content = await response.Content.ReadFromJsonAsync<LoginResponse>();
            if (content == null)
                throw new InvalidDataException();

            LoginResponse.JwtToken = content.JwtToken;
            LoginResponse.ExpirationDate = content.ExpirationDate;

            return LoginResponse.ExpirationDate;
        }

        public async Task RegisterAsync(RegisterModel model)
        {
            var response = await Client.PostAsync("api/account/register", JsonContent.Create(model));
            if (!response.IsSuccessStatusCode)        
            throw new UnauthorizedAccessException("Failed to create user");

        }
    }
}
