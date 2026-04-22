using System.Collections.Generic;
using ProductManager.Data;
using ProductManager.Data;

namespace ProductManager.Data
{
    public interface IProductRepo
    {
        // Замість Product пиши ProductsStorage
        IEnumerable<ProductsStorage> GetAll();
        IEnumerable<ProductsStorage> GetByDepositoryId(int depositoryId);
        ProductsStorage GetById(int id);
        void Add(ProductsStorage product);
        void Update(ProductsStorage product);
        void Delete(int id);
    }
}