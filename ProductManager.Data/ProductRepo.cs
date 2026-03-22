using System.Collections.Generic;
using System.Linq;
using StorageClasses;

namespace ProductManager.Data
{
    public class ProductRepo : IProductRepo
    {
        public IEnumerable<ProductsStorage> GetAll() => StarterStorage.Products;

        public ProductsStorage GetById(int id) =>
            StarterStorage.Products.FirstOrDefault(p => p.Id == id);

        public IEnumerable<ProductsStorage> GetByDepositoryId(int depositoryId) =>
            StarterStorage.Products.Where(p => p.DepositaryId == depositoryId);
    }
}