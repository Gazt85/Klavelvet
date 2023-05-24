using Contracts.CartContracts;
using Contracts.CategoryContracts;
using Klavelvet.Server.Repository.ProductRepository;

namespace Klavelvet.Server.Repository.RepositoryManager
{
    public interface IRepositoryManager
    {
        IProductRepository Product { get; }

        ICategoryRepository Category { get; }

        ICartRepository Cart { get; }
    }
}
