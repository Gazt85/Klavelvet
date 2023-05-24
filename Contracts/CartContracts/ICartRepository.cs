using Klavelvet.Shared.Data_Transfer_Objects.Cart;

namespace Contracts.CartContracts
{
    public interface ICartRepository
    {
        Task<List<CartItemDto>> GetCartProducts(List<CartItemForCreationDto> cartItems, bool trackChanges);

    }
}
