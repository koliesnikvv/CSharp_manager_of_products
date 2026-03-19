//obvious, storage for products
using ProductManager.Data;
using ProductManager.Data;
using System.Collections.Generic;
using System.Linq;

namespace ProductManager.Data.Storage
{
    public class ProductsStorage
    {
        private List<Product> _products;

        public ProductsStorage()
        {
            InitializeData();
            LinkProductsToDepositories();
        }

        private void InitializeData()
        {
            _products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Candle",
                    Category = ProductsCategory.Home,
                    PricePerItem = 430m,
                    Quantity = 70,
                    Description = "Vanilla candle that makes your home smelling like baked bun"
                },
                new Product
                {
                    Id = 2,
                    Name = "Sony WH-1000XM4 Headphones",
                    Category = ProductsCategory.Electronics,
                    PricePerItem = 1500m,
                    Quantity = 12,
                    Description = "Wireless, noise cancelling, black"
                },
                new Product
                {
                    Id = 3,
                    Name = "Green Tea",
                    Category = ProductsCategory.Grocery,
                    PricePerItem = 30m,
                    Quantity = 56,
                    Description = "Delicious green tea, antibloating"
                },
                new Product
                {
                    Id = 4,
                    Name = "C# Programming Book",
                    Category = ProductsCategory.Books,
                    PricePerItem = 900m,
                    Quantity = 20,
                    Description = "Learn C# from scratch, includes exercises"
                },
                new Product
                {
                    Id = 5,
                    Name = "Nike T-Shirt",
                    Category = ProductsCategory.Clothing,
                    PricePerItem = 890m,
                    Quantity = 85,
                    Description = "Cotton, black, sizes XS-XXL"
                },
                new Product
                {
                    Id = 6,
                    Name = "Hot Wheels Car Porsche",
                    Category = ProductsCategory.Toys,
                    PricePerItem = 169m,
                    Quantity = 28,
                    Description = "Fast hot wheels car Porsche, limited edition"
                },
                new Product
                {
                    Id = 7,
                    Name = "Chocolate bar with almond",
                    Category = ProductsCategory.Grocery,
                    PricePerItem = 79m,
                    Quantity = 100,
                    Description = "Milk chocolate with almonds, whole nut"
                },
                new Product
                {
                    Id = 8,
                    Name = "Running Shoes",
                    Category = ProductsCategory.Footwear,
                    PricePerItem = 2200m,
                    Quantity = 15,
                    Description = "Comfortable running shoes, sizes 35-44"
                },
                new Product
                {
                    Id = 9,
                    Name = "Face Cream",
                    Category = ProductsCategory.Beauty,
                    PricePerItem = 150m,
                    Quantity = 22,
                    Description = "Moisturizing cream for dry skin"
                },
                new Product
                {
                    Id = 10,
                    Name = "Lego Set",
                    Category = ProductsCategory.Toys,
                    PricePerItem = 1600m,
                    Quantity = 16,
                    Description = "Star Wars series, 300 pieces"
                },
                new Product
                {
                    Id = 11,
                    Name = "Samsung Tablet",
                    Category = ProductsCategory.Electronics,
                    PricePerItem = 4800m,
                    Quantity = 5,
                    Description = "10 inch display, 64GB, gray"
                },
                new Product
                {
                    Id = 12,
                    Name = "Phone Case",
                    Category = ProductsCategory.Accessories,
                    PricePerItem = 250m,
                    Quantity = 40,
                    Description = "Silicone case for iPhones"
                },
                new Product
                {
                    Id = 13,
                    Name = "Coffee Mug",
                    Category = ProductsCategory.Home,
                    PricePerItem = 299m,
                    Quantity = 60,
                    Description = "Ceramic mug with funny cat print"
                },
                new Product
                {
                    Id = 14,
                    Name = "Wuthering Heights",
                    Category = ProductsCategory.Books,
                    PricePerItem = 400m,
                    Quantity = 67,
                    Description = "Heartbreaking story of forbidden love"
                }
            };
        }

        private void LinkProductsToDepositories()
        {
            var depositoryStorage = new DepositoryStorage();
            var depositories = depositoryStorage.GetAllDepositories();
            var kyivDepository = depositories.First(d => d.Id == 1);
            kyivDepository.Products.AddRange(_products.Take(10));
            var lvivDepository = depositories.First(d => d.Id == 2);
            lvivDepository.Products.AddRange(_products.Skip(10).Take(2));
            var odesaDepository = depositories.First(d => d.Id == 3);
            odesaDepository.Products.AddRange(_products.Skip(12).Take(2));
        }
        public List<Product> GetAllProducts() => _products;

        public Product GetProductById(int id) =>_products.FirstOrDefault(p => p.Id == id);

        public List<Product> GetProductsByDepositoryId(int depositoryId)
        {
            var depositoryStorage = new DepositoryStorage();
            var depository = depositoryStorage.GetDepositoryById(depositoryId);
            return depository?.Products ?? new List<Product>();
        }
    }
}