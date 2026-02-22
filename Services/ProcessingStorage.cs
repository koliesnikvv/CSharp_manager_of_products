using System.Collections.Generic;
using StorageClasses;

//here we are processing and taking our data from starter storage

namespace ServicesClasses
{
    public static class ProcessingStorage
    {
        public static List<ProductsStorage> GetProducts()
        {
            return StarterStorage.Products;
        }
        public static ProductsStorage GetProductById(int productId)
        {
            for (int i = 0; i < StarterStorage.Products.Count; i++)
            {
                ProductsStorage foundProduct = StarterStorage.Products[i];
                if (foundProduct.Id == productId)
                {
                    return foundProduct;
                }
            }
            return null;
        }
    }
}
