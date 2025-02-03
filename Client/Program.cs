using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using CarAuctions.Client;
using MudBlazor.Services;
using CarAuctions.Client.Services;
using CarAuctions.Client.Services.SignalR;
using CarAuctions.Client.Services.HttpService;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient("WebAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));
builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("WebAPI"));
builder.Services.AddScoped<IHttpService, HttpService>();

builder.Services.AddMudServices();
builder.Services.AddScoped<ChatHub>();
builder.Services.AddScoped<ChatHandler>();

await builder.Build().RunAsync();
