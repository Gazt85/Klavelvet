using Contracts.CartContracts;
using Klavelvet.Client.Services.ProductService;
using Klavelvet.Shared.Data_Transfer_Objects.Cart;
using Klavelvet.Shared.Data_Transfer_Objects.ProductVariant;
using Microsoft.AspNetCore.Components;

namespace Klavelvet.Client.Pages
{
    public partial class ProductDetails
    {
        [Inject]
        IProductService ProductService { get; set; }

        [Inject]
        ICartService CartService { get; set; }

        private int currentTypeId = 1;

        [Parameter]
        public Guid Id { get; set; }

        private ProductDto? Product;      

        protected override async Task OnParametersSetAsync()
        {
            var result = await ProductService.GetProduct(Id);

            if(result != null)
            {
                Product = result;

                if (Product.Variants.Any())
                {
                    currentTypeId = Product.Variants[0].ProductTypeId;
                }
            }
        }

        private ProductVariantDto GetSelectedVariant()        
            => Product.Variants.SingleOrDefault(v => v.ProductTypeId == currentTypeId);
        
        private async Task AddToCart()
        {
            var productVariant = GetSelectedVariant();

            var cartItem = new CartItemDto
            {
                ProductId = productVariant.ProductId,
                ProductTypeId = productVariant.ProductTypeId,
            };

            await CartService.AddToCart(cartItem);
        }       
    }
}
