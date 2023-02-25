using Klavelvet.Shared.Data_Transfer_Objects.Products;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace Klavelvet.Client.Shared
{
    public partial class ProductList
    {
        [Inject]
        public HttpClient HttpClient { get; set; }

        private List<ProductDto> Products = new();        

        protected override async Task OnInitializedAsync()
        {
            var result = await HttpClient.GetFromJsonAsync<List<ProductDto>>("api/Product");

            if (result != null)
            {
                Products= result;
            }          
        }        
    }
}
