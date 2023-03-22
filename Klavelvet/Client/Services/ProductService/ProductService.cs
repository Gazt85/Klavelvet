using Klavelvet.Client.Features;
using Klavelvet.Shared.Models;
using Klavelvet.Shared.RequestFeatures;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.WebUtilities;
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
        public PagingResponse<ProductDto> ProductResponse { get; set; } = new();
        public string Message { get; set; } = I18N.Product.ProductResources.LoadingPoducts;

        public async Task GetProducts(ProductParameters productsParameters, string? categoryUrl = null)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = productsParameters.PageNumber.ToString()
            };

            var response = categoryUrl == null ?
                 await _httpClient.GetAsync(QueryHelpers.AddQueryString("api/products/featured",queryStringParam)) :
                await _httpClient.GetAsync(QueryHelpers.AddQueryString($"api/products/category/{categoryUrl}",queryStringParam));          

            var content = await response.Content.ReadAsStringAsync();
            _unsuccessfulStatusCodeHandler.HandleStatusCode(response);

            var pagingResponse = new PagingResponse<ProductDto>
            {
                Items = JsonSerializer.Deserialize<List<ProductDto>>(content, _options),
                Metadata = JsonSerializer.Deserialize<Metadata>(
                    response.Headers.GetValues("X-Pagination").First(), _options)
            };

            ProductResponse = pagingResponse;

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

        public async Task SearchProducts(ProductParameters productsParameters, string searchText)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = productsParameters.PageNumber.ToString()
            };

            var response = await _httpClient
                .GetAsync(QueryHelpers.AddQueryString($"api/products/search/{searchText}", queryStringParam));

            var content = await response.Content.ReadAsStringAsync();
            _unsuccessfulStatusCodeHandler.HandleStatusCode(response);

            var pagingResponse = new PagingResponse<ProductDto>
            {
                Items = JsonSerializer.Deserialize<List<ProductDto>>(content, _options),
                Metadata = JsonSerializer.Deserialize<Metadata>(
                   response.Headers.GetValues("X-Pagination").First(), _options)
            };

            if (pagingResponse != null)
                ProductResponse = pagingResponse;

            if (!pagingResponse.Items.Any())
                Message = I18N.Product.ProductResources.NoProductsFound;

            ProductsChanged?.Invoke();
        }
    }
}
