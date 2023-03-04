using AutoMapper;
using Contracts;
using Contracts.CategoryContracts;
using Klavelvet.Server.Repository.RepositoryManager;
using Klavelvet.Shared.Data_Transfer_Objects.Category;
using Klavelvet.Shared.Data_Transfer_Objects.Products;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Klavelvet.Server.Controllers
{
    [Route("api/categories")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        private readonly ILoggerService _loggerService;

        public CategoryController(IRepositoryManager repositoryManager,
             IMapper mapper,
            ILoggerService loggerService)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
            _loggerService=loggerService;
        }

        [HttpGet]
        public async Task<ActionResult<List<CategoryDto>>> GetCategories()
        {
            var categories = await _repositoryManager.Category.GetCategoriesAsync(trackChanges: false);

            if (categories == null)
            {
                _loggerService.LogError($"There are no Categories in the database.");
                return NotFound();
            }

            var categoriesDto = _mapper.Map<IEnumerable<CategoryDto>>(categories);
            return Ok(categoriesDto);
        }
    }
}
