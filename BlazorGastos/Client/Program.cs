using BlazorGastos.Client;
using BlazorGastos.Client.Repositorios;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// peticion scoped para poder consumir un endpoint mediante el servicio httpclient
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

//centralizacion de sevicios como ejemplo
ConfigureServices(builder.Services);

await builder.Build().RunAsync();

void ConfigureServices(IServiceCollection services)
{
    services.AddSingleton<ServiciosSingleton>();
    services.AddTransient<ServiciosTransient>();
    services.AddSingleton<IGasto, Gasto>();
}
