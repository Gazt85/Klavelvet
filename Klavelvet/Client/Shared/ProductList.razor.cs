using Klavelvet.Client.Services.ProductService;
using Microsoft.AspNetCore.Components;

namespace Klavelvet.Client.Shared
{
    public partial class ProductList
    {
        [Inject]
        public IProductService ProductService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await ProductService.GetProducts();
        }

    }
}
