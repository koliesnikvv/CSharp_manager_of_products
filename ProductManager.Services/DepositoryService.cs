using ProductManager.Data;
using ProductManager.Services;
using System.Collections.Generic;
using System.Linq;

namespace ProductManager.Services
{
    public class DepositoryService : IDepositoryServices
    {
        private readonly IDepositoryRepo _depositoryRepo;
        private readonly IProductRepo _productRepo;
        public DepositoryService(IDepositoryRepo depositoryRepo,IProductRepo productRepo)
        {
            _depositoryRepo = depositoryRepo;
            _productRepo = productRepo;
        }
        public IEnumerable<DepositoryListDto> GetAllDepositories()
        {
            var depositories = _depositoryRepo.GetAll();

            return depositories.Select(d => new DepositoryListDto
            {
                Id = d.Id,
                Name = d.Name,
                Location = d.Location.ToString()
            });
        }
        public DepositoryDetailsDto GetDepositoryDetails(int id)
        {
            var depository = _depositoryRepo.GetById(id);
            if (depository == null)
                return null;

            var products = _productRepo.GetByDepositoryId(id);

            return new DepositoryDetailsDto
            {
                Id = depository.Id,
                Name = depository.Name,
                Location = depository.Location.ToString(),
                TotalValue = depository.TotalValue,
                Products = products.Select(p => new ProductListDto
                {
                    Id = p.Id,
                    Name = p.Name,
                    Category = p.Category.ToString(),
                    PricePerItem = p.PricePerItem,
                    Quantity = p.Quantity
                }).ToList()
            };
        }
    }
}