using DemoBlazorLezione2.Core.Conferenze;
using DemoBlazorLezione2.Core.ReqRes;
using DemoBlazorLezione2.WASM;
using DemoBlazorLezione2.WASM.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IServizioConferenze, ServizioConferenzeWASM>();
builder.Services.AddScoped<IReqResData, ServizioReqResWASM>();


await builder.Build().RunAsync();
