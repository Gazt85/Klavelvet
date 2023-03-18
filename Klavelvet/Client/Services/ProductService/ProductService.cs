using Klavelvet.Client.Features;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using System.Text.Json;

namespace Klavelvet.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;
        private UnsuccessfulStatusCodeHandler _unsuccessfulStatusCodeHandler;

        private readonly JsonSerializerOptions _options =
            new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        public event Action ProductsChanged;

        public ProductService(HttpClient httpClient, NavigationManager navigationManager)
        {
            _httpClient = httpClient;
            _unsuccessfulStatusCodeHandler = new UnsuccessfulStatusCodeHandler(navigationManager);
        }
        public List<ProductDto> Products { get; set; } = new();
        public string Message { get; set; } = I18N.Product.ProductResources.LoadingPoducts;

        public async Task GetProducts(string? categoryUrl = null)
        {
            var response = categoryUrl == null ?
                await _httpClient.GetAsync("api/products") :
                await _httpClient.GetAsync($"api/products/category/{categoryUrl}");

            var content = await response.Content.ReadAsStringAsync();
            _unsuccessfulStatusCodeHandler.HandleStatusCode(response);

            Products = JsonSerializer.Deserialize<List<ProductDto>>(content, _options);

            ProductsChanged.Invoke();
        }

        public async Task<ProductDto> GetProduct(Guid productId)
        {
            var response = await _httpClient.GetAsync($"api/products/{productId}");

            var content = await response.Content.ReadAsStringAsync();
            _unsuccessfulStatusCodeHandler.HandleStatusCode(response);

            return JsonSerializer.Deserialize<ProductDto>(content, _options);
        }

        public async Task<List<string>> GetProductSearchSuggestions(string searchText)
            => await _httpClient
            .GetFromJsonAsync<List<string>>($"api/products/searchsuggestions/{searchText}") ?? new List<string>();

        public async Task SearchProducts(string searchText)
        {
            var response = await _httpClient
                .GetFromJsonAsync<List<ProductDto>>($"api/products/search/{searchText}");

            if (response != null)
                Products = response;

            if (!Products.Any())
                Message = I18N.Product.ProductResources.NoProductsFound;

            ProductsChanged?.Invoke();
        }
    }
}
