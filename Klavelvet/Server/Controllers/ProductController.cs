using AutoMapper;
using Contracts;
using Klavelvet.Server.Repository.RepositoryManager;
using Klavelvet.Shared.Data_Transfer_Objects.Products;
using Klavelvet.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace Klavelvet.Server.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        private readonly ILoggerService _loggerService;

        public ProductController(IRepositoryManager repositoryManager,
            IMapper mapper,
            ILoggerService loggerService)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
            _loggerService=loggerService;
        }

        [HttpGet]
        public async Task<ActionResult<List<ProductDto>>> GetProducts()
        {
            var products = await _repositoryManager.Product.GetProductsAsync(trackChanges: false);

            if (products == null)
            {
                _loggerService.LogError($"There are no Products in the database.");
                return NotFound();
            }

            var productsDto = _mapper.Map<IEnumerable<ProductDto>>(products).ToList();

            return Ok(productsDto);
        }

        [HttpGet("category/{categoryUrl}")]
        public async Task<ActionResult<List<ProductDto>>> GetProductsByCategory(string categoryUrl)
        {
            var category = await _repositoryManager.Category.GetCategoryByUrl(categoryUrl,trackChanges: false);

            if (category == null)
            {
                _loggerService.LogError($"Category with url {categoryUrl} doesn't exists in the database.");
                return NotFound();
            }

            var products = await _repositoryManager.Product.GetProductsByCategoryAsync(categoryUrl, trackChanges: false);

            if (products == null)
            {
                _loggerService.LogError($"There are no Products for the category {categoryUrl} in the database.");
                return NotFound();
            }

            var productsDto = _mapper.Map<IEnumerable<ProductDto>>(products).ToList();

            return Ok(productsDto);
        }

        [HttpGet("{productId}")]
        public async Task<ActionResult<ProductDto>> GetProduct(Guid productId)
        {
            var product = await _repositoryManager.Product.GetProductAsync(productId, trackChanges: false);

            if (product == null)
            {
                _loggerService.LogError($"Product with id: {productId} doesn't exists in the database.");
                return NotFound();
            }

            var productDto = _mapper.Map<ProductDto>(product);
            return Ok(productDto);

        }
    }
}
