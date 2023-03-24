using Klavelvet.Client.Services.ProductService;
using Microsoft.AspNetCore.Components;

namespace Klavelvet.Client.Shared
{
    public partial class FeaturedProducts
    {
        [Inject]
        public IProductService ProductService { get; set; }

        [Parameter]
        public List<ProductDto> Products { get; set; } = new();       
    }
}
