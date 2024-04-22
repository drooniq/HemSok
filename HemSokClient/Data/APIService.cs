using HemSokClient.Models;
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
        public HttpClient Client { get; }

        public List<Agency> Agencies { get; set; }
        public List<Agent> Agents { get; set; }
        public List<Category> Categories { get; set; }
        public List<County> Counties { get; set; }
        public List<Municipality> Municipality { get; set; }
        public List<Residence> Residences { get; set; }

        public APIService(HttpClient Client)
        {
            this.Client = Client;
        }

        public async Task<bool> DeleteFromApiAsync<T>(string uri, T modelData) where T : class
        {
            // $"api/Residence/{residence.Id}
            var response = await Client.DeleteAsync(uri);
            return response.IsSuccessStatusCode;
        }

        public async Task<T> GetFromApiAsync<T>(string uri) where T : class
        {
            var response = await Client.GetAsync(uri);
            T modelData = (response.IsSuccessStatusCode) ? await response.Content.ReadFromJsonAsync<T>() : null;
            return modelData;
        }

        public async Task<List<T>> GetAllFromApiAsync<T>() where T : class
        {
            var response = await Client.GetAsync("api/" + typeof(T));
            List<T> modelData = (response.IsSuccessStatusCode) ? await response.Content.ReadFromJsonAsync<List<T>>() : null;
            return modelData;
        }

        public async Task<bool> PostToApiAsync<T>(T modelData) where T : class
        {
            var response = await Client.PostAsJsonAsync("api/" + typeof(T), modelData);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> PutToApiAsync<T>(string uri, T modelData) where T : class
        {
            var response = await Client.PutAsJsonAsync(uri, modelData);
            return response.IsSuccessStatusCode;
        }
    }
}
