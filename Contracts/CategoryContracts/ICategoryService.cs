using Klavelvet.Shared.Data_Transfer_Objects.Category;

namespace Contracts.CategoryContracts
{
    public interface ICategoryService
    {
        List<CategoryDto> Categories { get; set; }

        Task GetCategories();

        Task<CategoryDto> GetCategory(int categoryId);
    }
}
