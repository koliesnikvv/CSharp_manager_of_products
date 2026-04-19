using ProductManager.Data;
using StorageClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManager.Services
{
    public class DepositoryService : IDepositoryServices
    {
        private readonly IDepositoryRepo _depositoryRepo;
        private readonly IProductRepo _productRepo;

        public DepositoryService(IDepositoryRepo depositoryRepo, IProductRepo productRepo)
        {
            _depositoryRepo = depositoryRepo;
            _productRepo = productRepo;
        }

        public async Task<IEnumerable<DepositoryListDto>> GetAllDepositoriesAsync(string searchTerm = null, string sortBy = null)
        {
            var depositories = await _depositoryRepo.GetAllAsync();
            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                depositories = depositories.Where(d => d.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                d.Location.ToString().Contains(searchTerm, StringComparison.OrdinalIgnoreCase));
            }
            depositories = sortBy?.ToLower() switch
            {
                "name" => depositories.OrderBy(d => d.Name),
                "name_desc" => depositories.OrderByDescending(d => d.Name),
                "location" => depositories.OrderBy(d => d.Location),
                "location_desc" => depositories.OrderByDescending(d => d.Location),
                _ => depositories.OrderBy(d => d.Id)
            };

            return depositories.Select(d => new DepositoryListDto
            {
                Id = d.Id,
                Name = d.Name,
                Location = d.Location.ToString()
            });
        }

        public async Task<DepositoryDetailsDto> GetDepositoryDetailsAsync(int id)
        {
            var depository = await _depositoryRepo.GetByIdWithProductsAsync(id);
            if (depository == null)
                return null;

            return new DepositoryDetailsDto
            {
                Id = depository.Id,
                Name = depository.Name,
                Location = depository.Location.ToString(),
                TotalValue = depository.TotalValue,
                Products = depository.Products.Select(p => new ProductListDto
                {
                    Id = p.Id,
                    Name = p.Name,
                    Category = p.Category.ToString(),
                    PricePerItem = p.PricePerItem,
                    Quantity = p.Quantity,
                    Description = p.Description
                }).ToList()
            };
        }

        public async Task AddDepositoryAsync(DepositoryListDto depository)
        {
            var newDepository = new DepositaryStorage(0, depository.Name, Enum.Parse<DepositaryLocation>(depository.Location));
            await _depositoryRepo.AddAsync(newDepository);
        }

        public async Task UpdateDepositoryAsync(DepositoryListDto depository)
        {
            var existing = await _depositoryRepo.GetByIdAsync(depository.Id);
            if (existing != null)
            {
                existing.Name = depository.Name;
                existing.Location = Enum.Parse<DepositaryLocation>(depository.Location);
                await _depositoryRepo.UpdateAsync(existing);
            }
        }

        public async Task DeleteDepositoryAsync(int id)
        {
            await _depositoryRepo.DeleteAsync(id);
        }

        public async Task<ProductListDto> GetProductByIdAsync(int id)
        {
            var product = await _productRepo.GetByIdAsync(id);
            if (product == null) return null;

            return new ProductListDto
            {
                Id = product.Id,
                Name = product.Name,
                Category = product.Category.ToString(),
                PricePerItem = product.PricePerItem,
                Quantity = product.Quantity,
                Description = product.Description
            };
        }

        public async Task AddProductAsync(ProductListDto product, int depositoryId)
        {
            var newProduct = new ProductsStorage(0, product.Name)
            {
                DepositaryId = depositoryId,
                PricePerItem = product.PricePerItem,
                Quantity = product.Quantity,
                Category = Enum.Parse<ProductsCategory>(product.Category),
                Description = product.Description
            };
            await _productRepo.AddAsync(newProduct);
        }

        public async Task UpdateProductAsync(ProductListDto product)
        {
            var existing = await _productRepo.GetByIdAsync(product.Id);
            if (existing != null)
            {
                existing.Name = product.Name;
                existing.PricePerItem = product.PricePerItem;
                existing.Quantity = product.Quantity;
                existing.Category = Enum.Parse<ProductsCategory>(product.Category);
                existing.Description = product.Description;
                await _productRepo.UpdateAsync(existing);
            }
        }

        public async Task DeleteProductAsync(int id)
        {
            await _productRepo.DeleteAsync(id);
        }
    }
}
    }
}