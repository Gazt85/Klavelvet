using Klavelvet.Client.Services.ProductService;
using Klavelvet.Shared.Data_Transfer_Objects.Products;
using Microsoft.AspNetCore.Components;

namespace Klavelvet.Client.Pages
{
    public partial class ProductDetails
    {
        [Inject]
        IProductService ProductService { get; set; }

        [Parameter]
        public Guid Id { get; set; }

        private ProductDto Product = null;      

        protected override async Task OnParametersSetAsync()
        {
            var result = await ProductService.GetProduct(Id);

            if(result != null)
            {
                Product = result;
            }
        }
    }
}
