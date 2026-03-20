using ProductManager.Services;
using System.Collections.Generic;

namespace ProductManager.Services{
    public interface IDepositoryServices
    {
            IEnumerable<DepositoryListDto> GetAllDepositories();
            DepositoryDetailsDto GetDepositoryDetails(int id);
        }
    }
