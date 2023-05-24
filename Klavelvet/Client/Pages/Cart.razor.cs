using Contracts.CartContracts;
using Klavelvet.Shared.Data_Transfer_Objects.Cart;
using Microsoft.AspNetCore.Components;

namespace Klavelvet.Client.Pages
{
    public partial class Cart
    {
        [Inject]
        ICartService CartService { get; set; }

        public List<CartItemDto> CartItems { get; private set; }

        public string Message { get; private set; } = $"{I18N.Cart.CartResources.LoadingCart}...";       

        protected override async Task OnInitializedAsync()
        {
            await LoadCart();
        }

        private async Task LoadCart()
        {
            if ((await CartService.GetCartItems()).Any() == false)
            {
                Message = I18N.Cart.CartResources.CartIsEmpty;
                CartItems = new List<CartItemDto>();
            }
            else
            {
                CartItems = await CartService.GetCartProdutcs();
            }
        }

        private async Task RemoveProductFromCart(Guid productId, int productTypeId)
        {
            await CartService.RemoveProductFromCart(productId, productTypeId);
            await LoadCart();
        }

        private async Task UpdateQuantity(ChangeEventArgs e, CartItemDto product)
        {
            if (int.TryParse(e.Value?.ToString(), out int quantityToUpdate) == false)
                return;

            if (quantityToUpdate < 1)
                quantityToUpdate = 1;

            product.Quantity = quantityToUpdate;
            await CartService.UpdateQuantity(product);                            
        }
    }   
}
