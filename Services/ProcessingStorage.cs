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



        //we do not have info on this data so it will remain commented until you add depository info to starter storage


        //public static List<ProductsStorage> GetProductByDepositorisId(int depositorisId)
        //{
        //    List<ProductsStorage> foundProducts = new List<ProductsStorage>();
        //    for (int i = 0; i < StarterStorage.Products.Count; i++)
        //    {
        //        ProductsStorage product = StarterStorage.Products[i];
        //        if (product.depositaryId == depositorisId)
        //        {
        //            foundProducts.Add(product);
        //        }
        //    }
        //    return foundProducts;

        //}


        //public static List<DepositaryStorage> GetDepositories()
        //{
        //    return StarterStorage.Depositories;
        //}
        //public static DepositaryStorage GetDepositaryById(int depositaryId)
        //{
        //    for (int i = 0; i < StarterStorage.Depositories.Count; i++)
        //    {
        //        DepositoryStorage foundDepositary = StarterStorage.Depositories[i];
        //        if (foundDepositary.DepositaryId == depositaryId)
        //        {
        //            return foundDepositary;
        //        }
        //    }
        //    return null;
        //}

        //public static int GetAmountOfProductsOnDepository(int depositoryId)
        //{
        //    int amount = 0;
        //    for (int i = 0; i < StarterStorage.Products.Count; i++)
        //    {
        //        if (StarterStorage.Products[i].DepositoryId == depositoryId)
        //        {
        //            amount++;
        //        }
        //    }
        //    return amount;
        //}
    }
}
