using AutoMapper;
using Contracts;
using Klavelvet.Server.Repository.RepositoryManager;
using Klavelvet.Shared.Data_Transfer_Objects.Cart;
using Microsoft.AspNetCore.Mvc;

namespace Klavelvet.Server.Controllers
{
    [Route("api/cart")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        private readonly ILoggerService _loggerService;

        public CartController(IRepositoryManager repositoryManager, IMapper mapper, ILoggerService loggerService)
        {
            _repositoryManager=repositoryManager;
            _mapper=mapper;
            _loggerService=loggerService;
        }

        [HttpPost("products")]
        public async Task<ActionResult<List<CartItemDto>>> GetCartProducts(List<CartItemForCreationDto> cartItems)
        {
            var cartProducts = await _repositoryManager.Cart.GetCartProducts(cartItems,trackChanges: false);            
           
            return Ok(cartProducts);
        }
    }
}
