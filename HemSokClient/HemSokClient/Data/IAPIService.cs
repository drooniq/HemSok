namespace HemSokClient.Data
{
    public interface IAPIService
    {
        Task<bool> DeleteFromApiAsync<T>(string uri, T modelData) where T : class;
        Task<List<T>> GetAllFromApiAsync<T>() where T : class;
        Task<T> GetFromApiAsync<T>(string uri) where T : class;
        Task<bool> PostToApiAsync<T>(T modelData) where T : class;
        Task<bool> PutToApiAsync<T>(string uri, T modelData) where T : class;
    }
}