using Klavelvet.Shared.Models;

namespace Contracts.CategoryContracts
{
    public interface ICategoryRepository
    {
        Task<List<Category>> GetCategoriesAsync(bool trackChanges);

    }
}
