using Contracts.CartContracts;
using Klavelvet.Server.Repository.RepositoryBase;
using Klavelvet.Shared.Data_Transfer_Objects.Cart;

namespace Klavelvet.Server.Repository.CartRepository
{
    public class CartRepository : RepositoryBase<Product>, ICartRepository
    {
        private readonly DataContext _context;

        public CartRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<CartItemDto>> GetCartProducts(List<CartItemForCreationDto> cartItems, bool trackChanges)
        {
            var result = new List<CartItemDto>();

            foreach (var cartItem in cartItems)
            {
                var product = await FindByCondition(p => p.Id == cartItem.ProductId, trackChanges).FirstOrDefaultAsync();

                if (product == null)
                    continue;

                var productVariant = await _context.ProductVariants
                    .Where(v => v.ProductId == cartItem.ProductId
                    && v.ProductTypeId == cartItem.ProductTypeId)
                    .Include(v => v.ProductType)
                    .FirstOrDefaultAsync();


                if (productVariant == null)
                    continue;

                var cartItemResponse = new CartItemDto
                {
                    ProductId = product.Id,
                    Title = product.Title,
                    ImageUrl = product.ImageURL,
                    Price = productVariant.Price,
                    ProductType = productVariant.ProductType.Name,
                    ProductTypeId = productVariant.ProductTypeId,
                    Quantity = cartItem.Quantity
                };

                result.Add(cartItemResponse);
            }
            return result;
        }
    }
}
