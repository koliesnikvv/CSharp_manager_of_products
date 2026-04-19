using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductManager.Data.Data;
using StorageClasses;

namespace ProductManager.Data
{
    public static class DatabaseInitializer
    {
        public static async Task InitializeAsync(AppDbContext context)
        {
            await context.Database.EnsureCreatedAsync();

            if (await context.Depositories.AnyAsync())
            {
                return; 
            }

            var depositories = new[]
            {
                new DepositaryStorage(1, "Kyiv Central Hub", DepositaryLocation.Kyiv),
                new DepositaryStorage(2, "Lviv Logistics Center", DepositaryLocation.Lviv),
                new DepositaryStorage(3, "Odesa Port Terminal", DepositaryLocation.Odesa)
            };

            await context.Depositories.AddRangeAsync(depositories);
            await context.SaveChangesAsync();

            var products = new[]
            {
                new ProductsStorage(1, "Smart Watch X20")
                {
                    DepositaryId = 1,
                    PricePerItem = 8500m,
                    Quantity = 12,
                    Category = ProductsCategory.Electronics,
                    Description = "Water-resistant smartwatch with advanced heart rate monitoring."
                },
                new ProductsStorage(2, "Scented Candle")
                {
                    DepositaryId = 1,
                    PricePerItem = 450m,
                    Quantity = 50,
                    Category = ProductsCategory.Home,
                    Description = "Hand-poured soy wax candle with a relaxing vanilla scent."
                },
                new ProductsStorage(3, "The Witcher: Last Wish")
                {
                    DepositaryId = 1,
                    PricePerItem = 580m,
                    Quantity = 25,
                    Category = ProductsCategory.Books,
                    Description = "Fantasy novel by Andrzej Sapkowski, deluxe hardcover edition."
                },
                new ProductsStorage(4, "Winter Parka")
                {
                    DepositaryId = 1,
                    PricePerItem = 4200m,
                    Quantity = 8,
                    Category = ProductsCategory.Clothing,
                    Description = "Heavy-duty winter jacket with thermal lining and faux-fur hood."
                },
                
                new ProductsStorage(5, "Mechanical Keyboard")
                {
                    DepositaryId = 2,
                    PricePerItem = 3100m,
                    Quantity = 15,
                    Category = ProductsCategory.Electronics,
                    Description = "Tactile mechanical keyboard with customizable RGB lighting."
                },
                new ProductsStorage(6, "Ceramic Vase")
                {
                    DepositaryId = 2,
                    PricePerItem = 1100m,
                    Quantity = 10,
                    Category = ProductsCategory.Home,
                    Description = "Handmade minimalist ceramic vase for home decor."
                },
                new ProductsStorage(7, "Leather Sneakers")
                {
                    DepositaryId = 2,
                    PricePerItem = 2800m,
                    Quantity = 20,
                    Category = ProductsCategory.Footwear,
                    Description = "Premium white leather sneakers for daily casual wear."
                },
                new ProductsStorage(8, "C# Programming Guide")
                {
                    DepositaryId = 2,
                    PricePerItem = 950m,
                    Quantity = 30,
                    Category = ProductsCategory.Books,
                    Description = "Comprehensive guide covering modern C# and .NET development."
                },
                
                new ProductsStorage(9, "Power Bank 20000mAh")
                {
                    DepositaryId = 3,
                    PricePerItem = 2200m,
                    Quantity = 40,
                    Category = ProductsCategory.Electronics,
                    Description = "High-capacity portable charger with fast-charging technology."
                },
                new ProductsStorage(10, "Face Serum")
                {
                    DepositaryId = 3,
                    PricePerItem = 750m,
                    Quantity = 60,
                    Category = ProductsCategory.Beauty,
                    Description = "Hydrating facial serum enriched with Vitamin C and minerals."
                },
                new ProductsStorage(11, "Sunglasses")
                {
                    DepositaryId = 3,
                    PricePerItem = 1500m,
                    Quantity = 15,
                    Category = ProductsCategory.Accessories,
                    Description = "Polarized sunglasses with UV400 protection and metal frame."
                },
                new ProductsStorage(12, "Lego Star Wars")
                {
                    DepositaryId = 3,
                    PricePerItem = 3400m,
                    Quantity = 5,
                    Category = ProductsCategory.Toys,
                    Description = "X-Wing Starfighter building set from the Star Wars collection."
                }
            };

            await context.Products.AddRangeAsync(products);
            await context.SaveChangesAsync();
        }
    }
}