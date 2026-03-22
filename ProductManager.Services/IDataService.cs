using System.Collections.Generic;
using ProductManager.Services; 

namespace ProductManager.Services
{
    public interface IDataService
    {
        // Returns a list of DTOs instead of repository models
        IEnumerable<DepositoryListDto> GetAllDepositories();

        // Returns detailed warehouse information via DTO
        DepositoryDetailsDto GetDepositoryDetails(int id);

        // Returns a list of products as DTOs
        IEnumerable<ProductListDto> GetProductsByDepositoryId(int depositaryId);

        int GetProductCount(int depositoryId);
    }
}