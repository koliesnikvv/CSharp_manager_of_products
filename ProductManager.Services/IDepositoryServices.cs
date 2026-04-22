using ProductManager.Services;
using System.Collections.Generic;

namespace ProductManager.Services{
    public interface IDepositoryServices
    {
        Task<IEnumerable<DepositoryListDto>> GetAllDepositoriesAsync(string searchTerm = null, string sortBy = null);
        Task<DepositoryDetailsDto> GetDepositoryDetailsAsync(int id);
        Task AddDepositoryAsync(DepositoryListDto depository);
        Task UpdateDepositoryAsync(DepositoryListDto depository);
        Task DeleteDepositoryAsync(int id);

        Task<ProductListDto> GetProductByIdAsync(int id);
        Task AddProductAsync(ProductListDto product, int depositoryId);
        Task UpdateProductAsync(ProductListDto product);
        Task DeleteProductAsync(int id);
     }
}
   
   
