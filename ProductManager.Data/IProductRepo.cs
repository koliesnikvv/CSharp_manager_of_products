using System.Collections.Generic;
using ProductManager.Data;

namespace ProductManager.Data
{
    public interface IProductRepo
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        IEnumerable<Product> GetByDepositoryId(int depositoryId);
    }
}
