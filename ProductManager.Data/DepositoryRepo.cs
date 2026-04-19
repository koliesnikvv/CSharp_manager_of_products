using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductManager.Data.Data;
using StorageClasses;


namespace ProductManager.Data;
        public class DepositoryRepo : IDepositoryRepo
        {
            private readonly AppDbContext _context;

            public DepositoryRepo(AppDbContext context)
            {
                _context = context;
            }

            public async Task<IEnumerable<DepositaryStorage>> GetAllAsync()
            {
                return await _context.Depositories.ToListAsync();
            }

            public async Task<DepositaryStorage> GetByIdAsync(int id)
            {
                return await _context.Depositories.FindAsync(id);
            }

            public async Task<DepositaryStorage> GetByIdWithProductsAsync(int id)
            {
                return await _context.Depositories
                    .Include(d => d.Products)
                    .FirstOrDefaultAsync(d => d.Id == id);
            }

            public async Task AddAsync(DepositaryStorage depository)
            {
                await _context.Depositories.AddAsync(depository);
                await _context.SaveChangesAsync();
            }

            public async Task UpdateAsync(DepositaryStorage depository)
            {
                _context.Depositories.Update(depository);
                await _context.SaveChangesAsync();
            }

            public async Task DeleteAsync(int id)
            {
                var depository = await GetByIdAsync(id);
                if (depository != null)
                {
                    _context.Depositories.Remove(depository);
                    await _context.SaveChangesAsync();}
            }
        }
 