using AutoMapper;
using Klavelvet.Server.Repository.RepositoryManager;
using Klavelvet.Shared.Data_Transfer_Objects.Products;
using Microsoft.AspNetCore.Mvc;

namespace Klavelvet.Server.Controllers
{
    [Route("api/products")]
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
        public async Task<ActionResult<ServiceResponse<List<ProductDto>>>> GetProducts()
        {
            var products = await _repositoryManager.Product.GetProductsAsync(trackChanges: false);

            var productsDto = _mapper.Map<IEnumerable<ProductDto>>(products);

            var response = new ServiceResponse<List<ProductDto>>()
            {
                Data = productsDto.ToList()
            };

            return Ok(response);
        }

        [HttpGet("{productId}") ]
        public async Task<ActionResult<ProductDto>> GetProduct(Guid productId)
        {
            var product = await _repositoryManager.Product.GetProductAsync(productId, trackChanges: false);

            if (product == null)
            {
               // _logger.LogInfo($"Appointment with id: {id} doesn't exists in the database.");
                return NotFound();
            }
            else
            {
                var productDto = _mapper.Map<ProductDto>(product);
                return Ok(productDto);
            }          
        }
    }
}
