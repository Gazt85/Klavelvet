using Klavelvet.Shared.Models;

namespace Contracts.CategoryContracts
{
    public interface ICategoryRepository
    {
        Task<List<Category>> GetCategoriesAsync(bool trackChanges);

        Task<Category> GetCategoryByUrl(string categoryUrl ,bool trackChanges);

    }
}
