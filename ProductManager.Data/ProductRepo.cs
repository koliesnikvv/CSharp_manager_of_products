using ProductManager.Data;
using System.Collections.Generic;

namespace ProductManager.Data
{
    public class ProductRepo : IProductRepo
    {
        private readonly ProductsStorage _storage;

        public ProductRepo()
        {
            _storage = new ProductsStorage();
        }

        public IEnumerable<Product> GetAll()
        {
            return _storage.GetAllProducts();
        }

        public Product GetById(int id)
        {
            return _storage.GetProductById(id);
        }

        public IEnumerable<Product> GetByDepositoryId(int depositoryId)
        {
            return _storage.GetProductsByDepositoryId(depositoryId);
        }
    }
}