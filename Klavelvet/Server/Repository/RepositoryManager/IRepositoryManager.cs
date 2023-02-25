using Klavelvet.Server.Repository.ProductRepository;

namespace Klavelvet.Server.Repository.RepositoryManager
{
    public interface IRepositoryManager
    {
        IProductRepository Product { get; }
    }
}
