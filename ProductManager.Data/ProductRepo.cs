using System.Collections.Generic;
using System.Linq;
using ProductManager.Data;
using Microsoft.EntityFrameworkCore;

namespace ProductManager.Data
{
    public class ProductRepo : IProductRepo
    {
        private readonly AppDbContext _context;

        public ProductRepo(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<ProductsStorage> GetAll()
        {
            // Отримуємо всі товари
            return _context.Products.ToList();
        }

        public IEnumerable<ProductsStorage> GetByDepositoryId(int depositoryId)
        {
            // Фільтруємо товари за ID складу
            return _context.Products
                           .Where(p => p.DepositoryId == depositoryId)
                           .ToList();
        }

        public ProductsStorage GetById(int id)
        {
            return _context.Products.FirstOrDefault(p => p.Id == id);
        }

        public void Add(ProductsStorage product)
        {
            _context.Products.Add(product);
        }

        public void Update(ProductsStorage product)
        {
            _context.Products.Update(product);
        }

        public void Delete(int id)
        {
            var product = GetById(id);
            if (product != null)
            {
                _context.Products.Remove(product);
            }
        }
    }
}