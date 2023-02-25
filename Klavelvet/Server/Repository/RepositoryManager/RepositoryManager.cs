using Klavelvet.Server.Repository.ProductRepository;

namespace Klavelvet.Server.Repository.RepositoryManager
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly DataContext _dataContext;

        private IProductRepository _productRepository;

        public RepositoryManager(DataContext dataContext)
        {
            _dataContext=dataContext;
        }

        public IProductRepository Product
        {
            get
            {
                if (_productRepository == null)
                    _productRepository = new ProductRepository.ProductRepository(_dataContext);

                return _productRepository;
            }
        }
    }
}
