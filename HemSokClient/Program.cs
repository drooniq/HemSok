using Blazored.LocalStorage;
using HemSokClient.Data;
using HemSokClient.Handlers;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
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

            // Register services
            builder.Services.AddScoped<INavigationStateService, NavigationStateService>();
            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddScoped<IAuthStateService, AuthStateService>();
            builder.Services.AddScoped<IAPIService, APIService>();
            builder.Services.AddTransient<AuthenticationHandler>();

            // Configure HttpClient
            builder.Services.AddHttpClient("CustomClient", client =>
            {
                client.BaseAddress = new Uri("https://localhost:7069/");
            }).AddHttpMessageHandler<AuthenticationHandler>();

            // Build the host
            var host = builder.Build();

            // Initialize AuthStateService
            var authStateService = host.Services.GetRequiredService<IAuthStateService>() as AuthStateService;
            if (authStateService != null)
            {
                Console.WriteLine("Program.cs = AuthStateService is not null");
                await authStateService.InitializeAsync();
            }
            else
            {
                Console.WriteLine("Program.cs = AuthStateService is null");
            }

            // Run the host
            await host.RunAsync();
        }
    }
}
