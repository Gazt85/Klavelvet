using Klavelvet.Client.Services.ProductService;
using Klavelvet.Shared.Data_Transfer_Objects.Products;
using Microsoft.AspNetCore.Components;

namespace Klavelvet.Client.Shared
{
    public partial class ProductList
    {        
        [Inject]
        private IProductService ProductService { get; set; }

        protected override async Task OnInitializedAsync() =>        
            await ProductService.GetProducts();
           
    }
}
