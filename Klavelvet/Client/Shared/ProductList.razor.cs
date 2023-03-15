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
            ProductService.ProductsChanged += StateHasChanged;
        }

        private string GetPriceText(ProductDto product)
        {
            var variants = product.Variants;

            if(!variants.Any())            
                return string.Empty;

            if (variants.Count == 1)
                return $"{variants[0].Price}";

            decimal minPrice = variants.Min(x => x.Price);
            return $"{I18N.Product.ProductResources.StartingAt} ${minPrice}";
        }

        public void Dispose()
        {
            ProductService.ProductsChanged -= StateHasChanged;
        }
    }
}
