using Blazored.Modal;
using eCommerce_Shop_Client;
using eCommerce_Shop_Client.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.SemanticKernel;
using MudBlazor.Services;
using Syncfusion.Blazor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddBlazoredModal();
builder.Services.AddSingleton<CartState>();
builder.Services.AddScoped<LoginState>();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7119") });
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1JFaF1cXGFCf1FpRGNGfV5ycUVHYlZTTXxcRU0DNHVRdkdmWH1ec3VXRGlfVkd3WUZWYEg=");
builder.Services.AddSyncfusionBlazor();
builder.Services.AddMudServices();
await builder.Build().RunAsync();
