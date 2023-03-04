using Contracts.CategoryContracts;
using Klavelvet.Client.Features;
using Klavelvet.Shared.Data_Transfer_Objects.Category;
using Klavelvet.Shared.Data_Transfer_Objects.Products;
using Klavelvet.Shared.Models;
using Microsoft.AspNetCore.Components;
using System.Text.Json;

namespace Klavelvet.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _httpClient;
        private UnsuccessfulStatusCodeHandler _unsuccessfulStatusCodeHandler;
        private readonly JsonSerializerOptions _options;


        public CategoryService(HttpClient httpClient, NavigationManager navigationManager)
        {
            _httpClient = httpClient;
            _unsuccessfulStatusCodeHandler = new UnsuccessfulStatusCodeHandler(navigationManager);
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        }

        public List<CategoryDto> Categories { get; set; } = new();

        public async Task GetCategories()
        {
            var response = await _httpClient.GetAsync("api/categories");

            var content = await response.Content.ReadAsStringAsync();
            _unsuccessfulStatusCodeHandler.HandleStatusCode(response);

            var result = JsonSerializer.Deserialize<List<CategoryDto>>(content, _options);

            if (result != null)
                Categories = result;
        }

        public async Task<CategoryDto> GetCategory(int categoryId)
        {
            var response = await _httpClient.GetAsync($"api/categories/{categoryId}");

            var content = await response.Content.ReadAsStringAsync();
            _unsuccessfulStatusCodeHandler.HandleStatusCode(response);

            return JsonSerializer.Deserialize<CategoryDto>(content, _options);
        }
    }
}
