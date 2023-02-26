﻿namespace Klavelvet.Server.Repository.ProductRepository
{
    public interface IProductRepository
    {
        Task<List<Product>> GetProductsAsync(bool trackChanges);

        Task<Product> GetProductAsync(Guid id, bool trackChanges);
    }
}