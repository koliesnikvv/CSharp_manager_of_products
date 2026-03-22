using System.Collections.Generic;
using StorageClasses;

namespace ProductManager.Data
{
    public interface IProductRepo
    {
        IEnumerable<ProductsStorage> GetAll();
        ProductsStorage GetById(int id);
        IEnumerable<ProductsStorage> GetByDepositoryId(int depositoryId);
    }
}