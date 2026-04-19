using Microsoft.EntityFrameworkCore;
using ProductManager.Data;
using System.Collections.Generic;
using System.Linq;

namespace ProductManager.Services
{
    public class DepositoryService : IDepositoryService
    {
        private readonly AppDbContext _context;

        public DepositoryService(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<DepositoryListDto> GetAllDepositories()
        {
            return _context.Depositaries
                .Select(d => new DepositoryListDto
                {
                    Id = d.Id,
                    Name = d.Name
                }).ToList();
        }

        public DepositoryDetailsDto GetDepositoryById(int id)
        {
            var depository = _context.Depositaries
                .Include(d => d.Products)
                .FirstOrDefault(d => d.Id == id);

            if (depository == null) return null;

            return new DepositoryDetailsDto
            {
                Id = depository.Id,
                Name = depository.Name,
                Products = depository.Products.Select(p => new ProductListDto
                {
                    Id = p.Id,
                    Name = p.Name,
                    Category = p.Category,
                    PricePerItem = (decimal)p.PricePerItem,
                    Quantity = p.Quantity
                }).ToList()
            };
        }
    }
}