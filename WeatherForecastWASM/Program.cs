using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using NETWeatherAPI;
using WeatherForecastWASM;
using WeatherForecastWASM.Data;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddOptions<WeatherConfiguration>().BindConfiguration("Weather").ValidateOnStart();

builder.Services.AddScoped(provider =>
{
    return new WeatherAPIClient("ebc78db5c0f6448fa6863903240903", new Uri("https://api.weatherapi.com/v1/"));
});

await builder.Build().RunAsync();
