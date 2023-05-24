using Blazored.LocalStorage;
using Contracts.CartContracts;
using Klavelvet.Shared;
using Klavelvet.Shared.Data_Transfer_Objects.Cart;
using Klavelvet.Shared.Models;
using System.Net.Http.Json;

namespace Klavelvet.Client.Services
{
    public class CartService : ICartService
    {
        private readonly ILocalStorageService _localStorageService;
        private readonly HttpClient _httpClient;

        public CartService(ILocalStorageService localStorageService,
            HttpClient httpClient)
        {
            _localStorageService=localStorageService;
            _httpClient=httpClient;
        }

        public event Action OnChange;

        public async Task AddToCart(CartItemDto cartItem)
        {
            var cart = await GetExistingCartOrCreate();            

            AddItem(cart, cartItem);                        

            await _localStorageService.SetItemAsync("cart", cart);
            OnChange?.Invoke();
        }       

        public async Task<List<CartItemDto>> GetCartItems()
            => await GetExistingCartOrCreate();

        public async Task<List<CartItemDto>> GetCartProdutcs()
        {
            var cartItems = await _localStorageService.GetItemAsync<List<CartItemForCreationDto>>("cart");

            var response = await _httpClient.PostAsJsonAsync("api/cart/products", cartItems);

            return await response?.Content.ReadFromJsonAsync<List<CartItemDto>>();
        }

        public async Task UpdateQuantity(CartItemDto product)
        {
            var cart = await _localStorageService.GetItemAsync<List<CartItemDto>>("cart");

            if (cart == null)
                return;

            CartItemDto? cartItem = FindCartItemByProductIdAndProductTypeId(product.ProductId, product.ProductTypeId, cart);

            if (cartItem != null)
            {
                cartItem.Quantity = product.Quantity;
                await _localStorageService.SetItemAsync("cart", cart);
            }
        }       

        public async Task RemoveProductFromCart(Guid productId, int productTypeId)
        {
            var cart = await _localStorageService.GetItemAsync<List<CartItemDto>>("cart");

            if (cart == null)
                return;

            CartItemDto? cartItem = FindCartItemByProductIdAndProductTypeId(productId, productTypeId, cart);            
            
            if(cartItem != null)
            {
                cart.Remove(cartItem);
                await _localStorageService.SetItemAsync("cart", cart);
                OnChange.Invoke();
            }
        }

        private async Task<List<CartItemDto>> GetExistingCartOrCreate()
        {
            var cart = await _localStorageService.GetItemAsync<List<CartItemDto>>("cart");

            return cart ?? new List<CartItemDto>();
        }

        private CartItemDto? FindCartItemByProductIdAndProductTypeId(Guid productId, int productTypeId, List<CartItemDto> cart)
        {
            return cart?.Find(p => p.ProductId == productId
           && p.ProductTypeId == productTypeId);
        }

        private void AddItem(List<CartItemDto> cart, CartItemDto cartItem)
        {
            var sameItem = cart.Find(p => p.ProductId== cartItem.ProductId &&
            p.ProductTypeId == cartItem.ProductTypeId);

            if (sameItem == null)
            {
                cart.Add(cartItem);
                return;
            }

            sameItem.Quantity += cartItem.Quantity;
        }       
    }
}
