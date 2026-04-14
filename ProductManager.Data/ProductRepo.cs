using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductManager.Data.Data;
using StorageClasses;


namespace ProductManager.Data
{ 
        public class ProductRepo : IProductRepo
        {
            private readonly AppDbContext _context;

            public ProductRepo(AppDbContext context)
            {
                _context = context;
            }

            public async Task<IEnumerable<ProductsStorage>> GetAllAsync()
            {
                return await _context.Products.ToListAsync();
            }

            public async Task<ProductsStorage> GetByIdAsync(int id)
            {
                return await _context.Products.FindAsync(id);
            }

            public async Task<IEnumerable<ProductsStorage>> GetByDepositoryIdAsync(int depositoryId)
            {
                return await _context.Products
                    .Where(p => p.DepositaryId == depositoryId)
                    .ToListAsync();
            }

            public async Task AddAsync(ProductsStorage product)
            {
                await _context.Products.AddAsync(product);
                await _context.SaveChangesAsync();
            }

            public async Task UpdateAsync(ProductsStorage product)
            {
                _context.Products.Update(product);
                await _context.SaveChangesAsync();
            }

            public async Task DeleteAsync(int id)
            {
                var product = await GetByIdAsync(id);
                if (product != null)
                {
                    _context.Products.Remove(product);
                    await _context.SaveChangesAsync();
                }
            }
        }
    }