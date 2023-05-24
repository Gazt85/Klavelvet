using Blazored.LocalStorage;
using Contracts.CartContracts;
using Klavelvet.Shared.Data_Transfer_Objects.Cart;
using Microsoft.AspNetCore.Components;

namespace Klavelvet.Client.Shared
{
    public partial class CartCounter
    {
        [Inject]
        ICartService CartService { get; set; }

        [Inject]
        ISyncLocalStorageService LocalStorageService { get; set; }


        private int GetCartItemsCount()
        {
            var cart = LocalStorageService.GetItem<List<CartItemDto>>("cart");
            return cart?.Count ?? 0;
        }

        protected override void OnInitialized()
        {
            CartService.OnChange += StateHasChanged;
        }

        public void Dispose()
        {
            CartService.OnChange -= StateHasChanged;
        }
    }
}
