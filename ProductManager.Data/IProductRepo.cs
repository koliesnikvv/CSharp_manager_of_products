using System.Collections.Generic;
using StorageClasses;
using System.Threading.Tasks;

namespace ProductManager.Data
{
    public interface IProductRepo
    {
        Task<IEnumerable<ProductsStorage>> GetAllAsync();
        Task<ProductsStorage> GetByIdAsync(int id);
        Task<IEnumerable<ProductsStorage>> GetByDepositoryIdAsync(int depositoryId);
        Task AddAsync(ProductsStorage product);
        Task UpdateAsync(ProductsStorage product);
        Task DeleteAsync(int id);
    }
}