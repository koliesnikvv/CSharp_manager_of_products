using System.Collections.Generic;
using ProductManager.Data;

namespace ProductManager.Services
{
    public interface IDepositoryService
    {
        // Метод для отримання списку всіх складів (для головної сторінки)
        IEnumerable<DepositoryListDto> GetAllDepositories();

        // Метод для отримання детальної інформації про склад (для сторінки деталей)
        DepositoryDetailsDto GetDepositoryById(int id);
    }
}