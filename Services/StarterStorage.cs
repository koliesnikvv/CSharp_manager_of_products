using System.Collections.Generic;
using StorageClasses;

//here we put our previous data, without doing any calculations with it


namespace ServicesClasses
{
    public static class StarterStorage
    {
        public static List<ProductsStorage> Products
        {
            get; private set;
        } = new List<ProductsStorage>();

        public static List<DepositaryStorage> Depositaries { get; private set; } = new List<DepositaryStorage>();
        static StarterStorage()
        {
            InitDepositories();
            InitProducts();
        }
        private static void InitProducts()
        {
            var product1 = new ProductsStorage(1, "Candle", 1);
            product1.Category = ProductsCategory.Home;
            product1.Price = 430;
            product1.Amount = 70;
            product1.Description = "Vanilla candle that makes your home smelling like baked bun";
            Products.Add(product1);

            var product2 = new ProductsStorage(2, "Sony WH-1000XM4 Headphones", 1);
            product2.Category = ProductsCategory.Electronics;
            product2.Price = 1500;
            product2.Amount = 12;
            product2.Description = "Wireless, noise cancelling, black";
            Products.Add(product2);

            var product3 = new ProductsStorage(3, "Green Tea", 1);
            product3.Category = ProductsCategory.Grocery;
            product3.Price = 30;
            product3.Amount = 56;
            product3.Description = "Delicious green tea, antibloating";
            Products.Add(product3);

            var product4 = new ProductsStorage(4, "C# Programming Book", 1);
            product4.Category = ProductsCategory.Books;
            product4.Price = 900;
            product4.Amount = 20;
            product4.Description = "Learn C# from scratch, includes exercises";
            Products.Add(product4);

            var product5 = new ProductsStorage(5, "Nike T-Shirt", 1);
            product5.Category = ProductsCategory.Clothing;
            product5.Price = 890;
            product5.Amount = 85;
            product5.Description = "Cotton, black, sizes XS-XXL";
            Products.Add(product5);

            var product6 = new ProductsStorage(6, "Hot Wheels Car Porsche", 1);
            product6.Category = ProductsCategory.Toys;
            product6.Price = 169;
            product6.Amount = 28;
            product6.Description = "Fast how wheels car Porsche, limited edition";
            Products.Add(product6);

            var product7 = new ProductsStorage(7, "Chocolate bar with almond", 1);
            product7.Category = ProductsCategory.Grocery;
            product7.Price = 79;
            product7.Amount = 100;
            product7.Description = "Milk chocolate with almonds, whole nut";
            Products.Add(product7);

            var product8 = new ProductsStorage(8, "Running Shoes", 1);
            product8.Category = ProductsCategory.Footwear;
            product8.Price = 2200;
            product8.Amount = 15;
            product8.Description = "Comfortable running shoes, sizes 35-44";
            Products.Add(product8);

            var product9 = new ProductsStorage(9, "Face Cream", 1);
            product9.Category = ProductsCategory.Beauty;
            product9.Price = 150;
            product9.Amount = 22;
            product9.Description = "Moisturizing cream for dry skin";
            Products.Add(product9);

            var product10 = new ProductsStorage(10, "Lego Set", 1);
            product10.Category = ProductsCategory.Toys;
            product10.Price = 1600;
            product10.Amount = 16;
            product10.Description = "Star Wars series, 300 pieces";
            Products.Add(product10);

            var product11 = new ProductsStorage(11, "Samsung Tablet", 2);
            product11.Category = ProductsCategory.Electronics;
            product11.Price = 4800;
            product11.Amount = 5;
            product11.Description = "10 inch display, 64GB, gray";
            Products.Add(product11);

            var product12 = new ProductsStorage(12, "Phone Case", 2);
            product12.Category = ProductsCategory.Accessories;
            product12.Price = 250;
            product12.Amount = 40;
            product12.Description = "Silicone case for iPhones 14, 14 Pro, 14 Pro Max, 15, 15 Pro, 15 Pro Max, 16, 16 Pro, 16 Pro Max, 17, 17 Pro, 17 Pro Max, black";
            Products.Add(product12);

            var product13 = new ProductsStorage(13, "Coffee Mug", 3);
            product13.Category = ProductsCategory.Home;
            product13.Price = 299;
            product13.Amount = 60;
            product13.Description = "Ceramic mug with funny cat print";
            Products.Add(product13);

            var product14 = new ProductsStorage(14, "Wuthering Heights", 1);
            product14.Category = ProductsCategory.Books;
            product14.Price = 400;
            product14.Amount = 67;
            product14.Description = "Heartbreaking story of forbidden love of Cathy and Heathcliff";
            Products.Add(product14);
        }
        private static void InitDepositories()
        {
            //Creating class objects
            Depositaries.Add(new DepositaryStorage(1, "Kyiv Central Hub", DepositaryLocation.Kyiv));
            Depositaries.Add(new DepositaryStorage(2, "Lviv Tech Warehouse", DepositaryLocation.Lviv));
            Depositaries.Add(new DepositaryStorage(3, "Odesa Port Terminal", DepositaryLocation.Odesa));
        }
    }
}
    


