using AutoMapper;
using Klavelvet.Server.Repository.RepositoryManager;
using Klavelvet.Shared.Data_Transfer_Objects.Products;
using Klavelvet.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace Klavelvet.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public ProductController(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetPtoducts()
        {
            var products = await _repositoryManager.Product.GetProductsAsync(trackChanges: false);

            var productsDto = _mapper.Map<IEnumerable<ProductDto>>(products);

            return Ok(productsDto);
        }        
    }
}
