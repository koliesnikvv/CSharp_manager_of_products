using System.Collections.Generic;

namespace ProductManager.Services
{
    public interface IDataService
    {
        List<DepositaryStorage> GetDepositaryStorages();
        DepositaryStorage GetDepositaryById(int id);
        List<ProductsStorage> GetProductsByDepositaryId(int depositaryId);
        ProductsStorage GetProductsById(int productId);
        int GetProductCountInDepositary(int depositaryId);
        List<ProductsStorage> GetProducts();
    }
}
