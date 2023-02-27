using Klavelvet.Client.Features;
using Klavelvet.Shared.Data_Transfer_Objects.Products;
using Microsoft.AspNetCore.Components;
using System.Text.Json;

namespace Klavelvet.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;
        private UnsuccessfulStatusCodeHandler _unsuccessfulStatusCodeHandler;

        private readonly JsonSerializerOptions _options =
            new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        public ProductService(HttpClient httpClient, NavigationManager navigationManager)
        {
            _httpClient = httpClient;
            _unsuccessfulStatusCodeHandler = new UnsuccessfulStatusCodeHandler(navigationManager);
        }
        public List<ProductDto> Products { get; set; } = new();

        public async Task<ProductDto> GetProduct(Guid productId)
        {
            var response = await _httpClient.GetAsync($"api/products/{productId}");

            var content = await response.Content.ReadAsStringAsync();
            _unsuccessfulStatusCodeHandler.HandleStatusCode(response);

            var result = JsonSerializer.Deserialize<ProductDto>(content, _options);

            return result;
        }

        public async Task GetProducts()
        {
            var response = await _httpClient.GetAsync("api/products");

            var content = await response.Content.ReadAsStringAsync();
            _unsuccessfulStatusCodeHandler.HandleStatusCode(response);

            Products = JsonSerializer.Deserialize<List<ProductDto>>(content, _options);
        }
    }
}
