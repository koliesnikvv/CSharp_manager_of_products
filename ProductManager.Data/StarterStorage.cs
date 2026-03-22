using System.Collections.Generic;
using StorageClasses;

namespace ProductManager.Data
{
    public static class StarterStorage
    {
        public static List<ProductsStorage> Products { get; } = new List<ProductsStorage>();
        public static List<DepositaryStorage> Depositaries { get; } = new List<DepositaryStorage>();

        static StarterStorage()
        {
            //DEPOSITARIES
            Depositaries.Add(new DepositaryStorage(1, "Kyiv Central Hub", DepositaryLocation.Kyiv));
            Depositaries.Add(new DepositaryStorage(2, "Lviv Logistics Center", DepositaryLocation.Lviv));
            Depositaries.Add(new DepositaryStorage(3, "Odesa Port Terminal", DepositaryLocation.Odesa));

            //PRODUCTS

            //KYIV (ID = 1) 
            Products.Add(new ProductsStorage(1, "Smart Watch X20")
            { DepositaryId = 1, 
              PricePerItem = 8500m,
              Quantity = 12, 
              Category = ProductsCategory.Electronics, 
              Description = "Water-resistant smartwatch with advanced heart rate monitoring." });

            Products.Add(new ProductsStorage(2, "Scented Candle")
            { DepositaryId = 1, 
              PricePerItem = 450m, 
              Quantity = 50, 
              Category = ProductsCategory.Home, 
              Description = "Hand-poured soy wax candle with a relaxing vanilla scent." });

            Products.Add(new ProductsStorage(3, "The Witcher: Last Wish")
            { DepositaryId = 1, 
              PricePerItem = 580m, 
              Quantity = 25, 
              Category = ProductsCategory.Books, 
              Description = "Fantasy novel by Andrzej Sapkowski, deluxe hardcover edition." });

            Products.Add(new ProductsStorage(4, "Winter Parka")
            { DepositaryId = 1, 
              PricePerItem = 4200m, 
              Quantity = 8, 
              Category = ProductsCategory.Clothing, 
              Description = "Heavy-duty winter jacket with thermal lining and faux-fur hood." });

            //LVIV (ID = 2)
            Products.Add(new ProductsStorage(5, "Mechanical Keyboard")
            { DepositaryId = 2, 
              PricePerItem = 3100m, 
              Quantity = 15, 
              Category = ProductsCategory.Electronics, 
              Description = "Tactile mechanical keyboard with customizable RGB lighting." });

            Products.Add(new ProductsStorage(6, "Ceramic Vase")
            { DepositaryId = 2, 
              PricePerItem = 1100m, 
              Quantity = 10, 
              Category = ProductsCategory.Home, 
              Description = "Handmade minimalist ceramic vase for home decor." });

            Products.Add(new ProductsStorage(7, "Leather Sneakers")
            { DepositaryId = 2, 
              PricePerItem = 2800m, 
              Quantity = 20, 
              Category = ProductsCategory.Footwear, 
              Description = "Premium white leather sneakers for daily casual wear." });

            Products.Add(new ProductsStorage(8, "C# Programming Guide")
            { DepositaryId = 2, 
              PricePerItem = 950m, 
              Quantity = 30, 
              Category = ProductsCategory.Books, 
              Description = "Comprehensive guide covering modern C# and .NET development." });

            //ODESA (ID = 3)
            Products.Add(new ProductsStorage(9, "Power Bank 20000mAh")
            { DepositaryId = 3, 
              PricePerItem = 2200m, 
              Quantity = 40, 
              Category = ProductsCategory.Electronics, 
              Description = "High-capacity portable charger with fast-charging technology." });

            Products.Add(new ProductsStorage(10, "Face Serum")
            { DepositaryId = 3, 
              PricePerItem = 750m, 
              Quantity = 60, 
              Category = ProductsCategory.Beauty, 
              Description = "Hydrating facial serum enriched with Vitamin C and minerals." });

            Products.Add(new ProductsStorage(11, "Sunglasses")
            { DepositaryId = 3, 
              PricePerItem = 1500m, 
              Quantity = 15, 
              Category = ProductsCategory.Accessories, 
              Description = "Polarized sunglasses with UV400 protection and metal frame." });

            Products.Add(new ProductsStorage(12, "Lego Star Wars")
            { DepositaryId = 3, 
              PricePerItem = 3400m, 
              Quantity = 5, 
              Category = ProductsCategory.Toys, 
              Description = "X-Wing Starfighter building set from the Star Wars collection." });
        }
    }
    }