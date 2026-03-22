using System.Collections.Generic;

//here we are processing and taking our data from starter storage

namespace ProductManager.Services
{
    public class ProcessingStorage : IDataService
    {
        private readonly IStorageInit _storage;
        public ProcessingStorage(IStorageInit storage)
        {
            _storage = storage;
        }
        public List<ProductsStorage> GetProducts()
        {
            return _storage.Products;
        }
        public ProductsStorage GetProductsById(int productId)
        {
            foreach(var product in _storage.Products)
            {
                if (product.Id == productId)
                {
                    return product;
                }
            }
            return null;
        }
        public int GetProductCountInDepositary(int depositaryId)
        {
            int count = 0;
            foreach(var product in _storage.Products)
            {
                if(product.DepositaryId == depositaryId)
                {
                    count++;
                }
            }

            return count;
        }
        public List<DepositaryStorage> GetDepositaryStorages()
        {
            return _storage.Depositaries;
        }
        public DepositaryStorage GetDepositaryById(int depositaryId)
        {
            foreach(var depositary in _storage.Depositaries)
            {
                if(depositary.Id == depositaryId)
                {
                    return depositary;
                }
            }
            return null;
        }
        public List<ProductsStorage> GetProductsByDepositaryId(int depositaryId)
        {
           var res = new List<ProductsStorage>();
            foreach(var product in _storage.Products)
            {
                if(product.DepositaryId == depositaryId)
                {
                    res.Add(product);
                }
            }
            return res;
        }
    }
}
