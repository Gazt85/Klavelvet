global using Klavelvet.Shared.Models;
global using Klavelvet.Shared.Data_Transfer_Objects.Products;
using Contracts.CategoryContracts;
using Klavelvet.Client;
using Klavelvet.Client.Services.CategoryService;
using Klavelvet.Client.Services.ProductService;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Blazored.LocalStorage;
using Klavelvet.Client.Services;
using Contracts.CartContracts;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)});

builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICartService, CartService>();


await builder.Build().RunAsync();
