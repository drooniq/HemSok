using HemSokClient.Models;
using HemSokClient.Models.LoginModels;

/*
author: Emil Waara
*/
namespace HemSokClient.Data
{
    public interface IAPIService
    {     
        public List<Agency>? Agencies { get; set; }
        public List<Agent>? Agents { get; set; }
        public List<Category>? Categories { get; set; }
        public List<County>? Counties { get; set; }
        public List<Municipality>? Municipality { get; set; }
        public List<Residence>? Residences { get; set; }
        public CurrentUser currentUser { get; set; }


        Task<bool> DeleteFromApiAsync<T>(string uri, T modelData) where T : class;
        Task<List<T>?> GetAllFromApiAsync<T>() where T : class;
        Task<T?> GetFromApiAsync<T>(string uri) where T : class;
        Task<bool> PostToApiAsync<T>(T modelData) where T : class;
        Task<bool> PutToApiAsync<T>(T modelData) where T : class;
        Task<bool> LoginAsync(LoginModel model);
        Task RegisterAsync(RegisterModel model);
    }
}