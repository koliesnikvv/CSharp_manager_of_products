using ProductManager.Data;
using StorageClasses;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace ProductManager.Data
{
    public interface IDepositoryRepo

    {
        Task<IEnumerable<DepositaryStorage>> GetAllAsync();
        Task<DepositaryStorage> GetByIdAsync(int id);
        Task<DepositaryStorage> GetByIdWithProductsAsync(int id);
        Task AddAsync(DepositaryStorage depository);
        Task UpdateAsync(DepositaryStorage depository);
        Task DeleteAsync(int id);
    }
}
