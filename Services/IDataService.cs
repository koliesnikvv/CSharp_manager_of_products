using System.Collections.Generic;
using StorageClasses;


namespace ServicesClasses
{
    public interface IDataService
    {
        List<DepositaryStorage> GetDepositaryStorages();
        DepositaryStorage GetDepositaryById(int id);
        List<ProductsStorage> GetProductsByDepositaryId(int depositaryId);
        ProductsStorage GetProductsById(int productId);
        int GetProductCountInDepositary(int depositaryId);
    }
}
