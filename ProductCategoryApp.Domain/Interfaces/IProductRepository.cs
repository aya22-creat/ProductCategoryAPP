using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductCategoryApp.Domain.Products.Entities;

namespace ProductCategoryApp.Domain.Products
{
    public interface IProductRepository
    {
        Task<Product?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default); // cancelable
        Task<IEnumerable<Product>> GetAllAsync(CancellationToken cancellationToken = default); // not awaited once edit in memory
        Task<IEnumerable<Product>> GetByCategoryIdAsync(Guid categoryId, CancellationToken cancellationToken = default);
        Task AddAsync(Product product, CancellationToken cancellationToken = default);
        // not awaited once edit in memory
        void Update(Product product); // Update the product in the repository default
        void Delete(Product product); // Delete the product from the repository default
    }
}