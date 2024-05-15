using HemSokClient.Data;
using HemSokClient.Handlers;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Net.Http.Headers;

namespace HemSokClient
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");
            builder.Services.AddTransient<AuthenticationHandler>();

            builder.Services.AddScoped<IAPIService, APIService>();
            builder.Services.AddSingleton<IAuthStateService, AuthStateService>();
            builder.Services.AddScoped<INavigationStateService, NavigationStateService>();

            builder.Services.AddHttpClient("CustomClient", client =>
            {
                client.BaseAddress = new Uri("https://localhost:7069/");               
            }).AddHttpMessageHandler<AuthenticationHandler>();

            await builder.Build().RunAsync();
        }
    }
}
