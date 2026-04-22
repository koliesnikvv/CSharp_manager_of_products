using System;

namespace ProductManager.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            // Ініціалізуємо репозиторії, передаючи їм той самий контекст бази даних
            Depositaries = new DepositaryRepo(_context);
            Products = new ProductRepo(_context);
        }

        public IDepositoryRepo Depositaries { get; private set; }
        public IProductRepo Products { get; private set; }

        // Викликаємо SaveChanges у контексту БД
        public int Save()
        {
            return _context.SaveChanges();
        }

        // Очищення ресурсів
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}