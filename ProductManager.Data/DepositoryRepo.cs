using System.Collections.Generic;
using System.Linq;
using ProductManager.Data;
using Microsoft.EntityFrameworkCore;

namespace ProductManager.Data
{
    public class DepositaryRepo : IDepositoryRepo
    {
        private readonly AppDbContext _context;

        public DepositaryRepo(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<DepositaryStorage> GetAll()
        {
            // Отримуємо всі склади з бази даних
            return _context.Depositaries.ToList();
        }

        public DepositaryStorage GetById(int id)
        {
            return _context.Depositaries.FirstOrDefault(d => d.Id == id);
        }

        public void Add(DepositaryStorage depositary)
        {
            _context.Depositaries.Add(depositary);
        }

        public void Delete(int id)
        {
            var depositary = GetById(id);
            if (depositary != null)
            {
                _context.Depositaries.Remove(depositary);
            }
        }
    }
}