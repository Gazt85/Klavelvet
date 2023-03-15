using Contracts.CategoryContracts;
using Klavelvet.Server.Repository.RepositoryBase;

namespace Klavelvet.Server.Repository.CategoryRepository
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {

        public CategoryRepository(DataContext context) : base(context)
        {

        }

        public async Task<List<Category>> GetCategoriesAsync(bool trackChanges)
        {
            var categories = await FindAll(trackChanges).ToListAsync();

            return categories;
        }

        public async Task<Category> GetCategoryByUrl(string cateogryUrl, bool trackChanges)
        => await FindByCondition(p => p.Url.Equals(cateogryUrl), trackChanges)
      .SingleOrDefaultAsync();  
    }
}
