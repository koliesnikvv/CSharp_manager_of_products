using Microsoft.EntityFrameworkCore;

namespace ProductManager.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<DepositaryStorage> Depositaries { get; set; }
        public DbSet<ProductsStorage> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Файл створиться в папці виконання проекту
            optionsBuilder.UseSqlite("Data Source=warehouse.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // 1. Depositories
            modelBuilder.Entity<DepositaryStorage>().HasData(
                new DepositaryStorage { Id = 1, Name = "Kyiv Central Hub", Location = "Kyiv, UA" },
                new DepositaryStorage { Id = 2, Name = "Lviv Tech Warehouse", Location = "Lviv, UA" },
                new DepositaryStorage { Id = 3, Name = "Odesa Port Logistics", Location = "Odesa, UA" }
            );

            // 2. Products (All 14 items with full descriptions)
            modelBuilder.Entity<ProductsStorage>().HasData(
                // Kyiv Hub
                new ProductsStorage
                {
                    Id = 1,
                    Name = "Candle",
                    Category = "Home",
                    PricePerItem = 430,
                    Quantity = 70,
                    DepositoryId = 1,
                    Description = "Handcrafted scented soy candle with lavender essential oils. Burn time up to 40 hours. Eco-friendly and non-toxic."
                },
                new ProductsStorage
                {
                    Id = 2,
                    Name = "Sony WH-1000XM4",
                    Category = "Electronics",
                    PricePerItem = 12000,
                    Quantity = 12,
                    DepositoryId = 1,
                    Description = "Industry-leading noise canceling wireless headphones with touch sensor controls and long-lasting 30-hour battery life."
                },
                new ProductsStorage
                {
                    Id = 3,
                    Name = "Apple iPhone 15",
                    Category = "Electronics",
                    PricePerItem = 35000,
                    Quantity = 25,
                    DepositoryId = 1,
                    Description = "Latest model featuring a 6.1-inch Super Retina XDR display, advanced dual-camera system, and the powerful A16 Bionic chip."
                },
                new ProductsStorage
                {
                    Id = 4,
                    Name = "Kindle Paperwhite",
                    Category = "Gadgets",
                    PricePerItem = 6500,
                    Quantity = 40,
                    DepositoryId = 1,
                    Description = "High-resolution 6.8-inch display with adjustable warm light. Waterproof design, perfect for reading by the pool or in the bath."
                },
                new ProductsStorage
                {
                    Id = 5,
                    Name = "Logitech MX Master 3",
                    Category = "Accessories",
                    PricePerItem = 4200,
                    Quantity = 15,
                    DepositoryId = 1,
                    Description = "Professional wireless mouse designed for ultimate precision. MagSpeed electromagnetic scrolling and ergonomic shape."
                },

                // Lviv Warehouse
                new ProductsStorage
                {
                    Id = 6,
                    Name = "MacBook Air M2",
                    Category = "Electronics",
                    PricePerItem = 48000,
                    Quantity = 10,
                    DepositoryId = 2,
                    Description = "Supercharged by the M2 chip. Features a strikingly thin design, 8-core CPU, and up to 18 hours of battery life."
                },
                new ProductsStorage
                {
                    Id = 7,
                    Name = "Nike Air Max",
                    Category = "Clothing",
                    PricePerItem = 5400,
                    Quantity = 30,
                    DepositoryId = 2,
                    Description = "Classic lifestyle sneakers with visible Air-Sole unit for lightweight cushioning and maximum style. Durable rubber outsole."
                },
                new ProductsStorage
                {
                    Id = 8,
                    Name = "Samsung T7 SSD",
                    Category = "Storage",
                    PricePerItem = 4800,
                    Quantity = 50,
                    DepositoryId = 2,
                    Description = "1TB External Solid State Drive. Transfer massive files in seconds with USB 3.2 Gen 2. Shock-resistant and secure."
                },
                new ProductsStorage
                {
                    Id = 9,
                    Name = "Mechanical Keyboard",
                    Category = "Electronics",
                    PricePerItem = 3200,
                    Quantity = 20,
                    DepositoryId = 2,
                    Description = "Tenkeyless RGB mechanical gaming keyboard with blue switches for tactile feedback. Built with an aircraft-grade aluminum frame."
                },
                new ProductsStorage
                {
                    Id = 10,
                    Name = "Electric Kettle",
                    Category = "Appliances",
                    PricePerItem = 1800,
                    Quantity = 100,
                    DepositoryId = 2,
                    Description = "1.7L stainless steel kettle with rapid boil technology and automatic shut-off feature for safety. Modern minimalist design."
                },

                // Odesa Logistics
                new ProductsStorage
                {
                    Id = 11,
                    Name = "JBL Flip 6",
                    Category = "Electronics",
                    PricePerItem = 4500,
                    Quantity = 22,
                    DepositoryId = 3,
                    Description = "Powerful portable Bluetooth speaker with IP67 waterproof and dustproof rating. Delivers loud, crystal clear sound anywhere."
                },
                new ProductsStorage
                {
                    Id = 12,
                    Name = "Coffee Maker",
                    Category = "Appliances",
                    PricePerItem = 7500,
                    Quantity = 8,
                    DepositoryId = 3,
                    Description = "Semi-automatic espresso machine with a high-pressure pump and built-in milk frother. Perfect for lattes and cappuccinos."
                },
                new ProductsStorage
                {
                    Id = 13,
                    Name = "Backpack Antitheft",
                    Category = "Accessories",
                    PricePerItem = 2300,
                    Quantity = 60,
                    DepositoryId = 3,
                    Description = "Anti-theft business backpack with hidden zippers, integrated USB charging port, and water-repellent fabric."
                },
                new ProductsStorage
                {
                    Id = 14,
                    Name = "Smart Watch",
                    Category = "Electronics",
                    PricePerItem = 9000,
                    Quantity = 18,
                    DepositoryId = 3,
                    Description = "Advanced smartwatch with health tracking, GPS, and a vibrant AMOLED display. Monitors heart rate, sleep, and blood oxygen levels."
                }
            );
        }
    }
}