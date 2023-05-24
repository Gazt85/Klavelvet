
using Klavelvet.Shared.Data_Transfer_Objects.Cart;

namespace Contracts.CartContracts
{
    public interface ICartService
    {
        event Action OnChange;

        Task AddToCart(CartItemDto cartItem);
        Task<List<CartItemDto>> GetCartItems();

        Task<List<CartItemDto>> GetCartProdutcs();

        Task RemoveProductFromCart(Guid productId, int productTypeId);

        Task UpdateQuantity(CartItemDto cartItem);
    }
}
