using Klavelvet.Client.Services.ProductService;
using Microsoft.AspNetCore.Components;

namespace Klavelvet.Client.Shared
{
    public partial class ProductList : IDisposable
    {
        [Inject]
        public IProductService ProductService { get; set; }

        protected override void OnInitialized()
        {
            //await ProductService.GetProducts();
            ProductService.ProductsChanged += StateHasChanged;

        }

        public void Dispose()
        {
            ProductService.ProductsChanged -= StateHasChanged;
        }
    }
}
