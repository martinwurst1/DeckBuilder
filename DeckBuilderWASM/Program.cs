using DeckBuilderWASM.POCOs;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace DeckBuilderWASM
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");
            
            var httpClient = new HttpClient
            {
                BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
            };

            var domain = builder.HostEnvironment.BaseAddress.Trim('/').Trim('\n').Replace("\n", "")           // Entfernt alle Zeilenumbrüche
    .Replace("\r", "");

            httpClient.DefaultRequestHeaders.Add("Origin", domain);

            builder.Services.AddScoped(sp => httpClient);
            builder.Services.AddSingleton<Container>();
            await builder.Build().RunAsync();
        }
    }
}
