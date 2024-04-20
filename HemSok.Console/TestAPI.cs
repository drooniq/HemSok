using HemSok.Console.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HemSok.Console
{
    public enum HttpMethod
    {
        GET,
        POST,
        PUT,
        DELETE
    }

    public class TestAPI
    {
        private readonly HttpClient _client;

        public TestAPI(string baseUri)
        {
            _client = new HttpClient { BaseAddress = new Uri(baseUri) };
        }

        public async Task runAPITests<T>() where T : class
        {
            List<T>? responses;
            T? response;

            // Run GET (all) test
            responses = await _client.GetFromJsonAsync<List<T>>("/api/" + typeof(T).Name);
            System.Console.WriteLine("GetAll Test = " + typeof(T).Name + JsonSerializer.Serialize(responses, new JsonSerializerOptions { WriteIndented = true }));

            // Run GET (id) test
            if (responses != null && tryToGetId<T>(responses[0], out string? id))
            {
                response = await _client.GetFromJsonAsync<T>("/api/" + typeof(T).Name + "/" + id);
                System.Console.WriteLine("Get id Test = " + typeof(T).Name + JsonSerializer.Serialize(response, new JsonSerializerOptions { WriteIndented = true }));
            }

            // Run POST test
            //            response = await _client.PostAsJsonAsync<T>("/api/" + typeof(T).Name, responses[0]).Result.Content.ReadFromJsonAsync<T>();
            System.Console.ReadKey();
        }

        public bool tryToGetId<T>(T obj, out string? id) where T : class
        {
            Type type = typeof(T);
            PropertyInfo[] properties = type.GetProperties();

            foreach (PropertyInfo property in properties)
            {
                object? value = property.GetValue(obj);
                if (property.Name == "Id")
                {
                    id = (value != null) ? value.ToString() : "";
                    return true;
                }
            }

            id = null;
            return false;
        }
    }
}
