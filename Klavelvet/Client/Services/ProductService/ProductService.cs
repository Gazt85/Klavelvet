using Klavelvet.Shared.Data_Transfer_Objects.Products;
using Klavelvet.Shared;

namespace Klavelvet.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient=httpClient;
        }
        public List<ProductDto> Products { get; set; } = new();

        public async Task<ProductDto> GetProduct(Guid productId)
        {
            var result = await _httpClient.GetFromJsonAsync<ProductDto>($"api/products/{productId}");

            return result;
        }

        public async Task GetProducts()
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<ProductDto>>>("api/products");

            if (result != null && result.Data != null)
                Products = result.Data;
        }
    }
}
