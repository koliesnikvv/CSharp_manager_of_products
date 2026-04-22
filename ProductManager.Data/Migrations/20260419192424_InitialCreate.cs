using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductManager.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Depositaries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Location = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Depositaries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Category = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    PricePerItem = table.Column<double>(type: "REAL", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    DepositoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Depositaries_DepositoryId",
                        column: x => x.DepositoryId,
                        principalTable: "Depositaries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Depositaries",
                columns: new[] { "Id", "Location", "Name" },
                values: new object[,]
                {
                    { 1, "Kyiv, UA", "Kyiv Central Hub" },
                    { 2, "Lviv, UA", "Lviv Tech Warehouse" },
                    { 3, "Odesa, UA", "Odesa Port Logistics" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "DepositoryId", "Description", "Name", "PricePerItem", "Quantity" },
                values: new object[,]
                {
                    { 1, "Home", 1, "Handcrafted scented soy candle with lavender essential oils. Burn time up to 40 hours. Eco-friendly and non-toxic.", "Candle", 430.0, 70 },
                    { 2, "Electronics", 1, "Industry-leading noise canceling wireless headphones with touch sensor controls and long-lasting 30-hour battery life.", "Sony WH-1000XM4", 12000.0, 12 },
                    { 3, "Electronics", 1, "Latest model featuring a 6.1-inch Super Retina XDR display, advanced dual-camera system, and the powerful A16 Bionic chip.", "Apple iPhone 15", 35000.0, 25 },
                    { 4, "Gadgets", 1, "High-resolution 6.8-inch display with adjustable warm light. Waterproof design, perfect for reading by the pool or in the bath.", "Kindle Paperwhite", 6500.0, 40 },
                    { 5, "Accessories", 1, "Professional wireless mouse designed for ultimate precision. MagSpeed electromagnetic scrolling and ergonomic shape.", "Logitech MX Master 3", 4200.0, 15 },
                    { 6, "Electronics", 2, "Supercharged by the M2 chip. Features a strikingly thin design, 8-core CPU, and up to 18 hours of battery life.", "MacBook Air M2", 48000.0, 10 },
                    { 7, "Clothing", 2, "Classic lifestyle sneakers with visible Air-Sole unit for lightweight cushioning and maximum style. Durable rubber outsole.", "Nike Air Max", 5400.0, 30 },
                    { 8, "Storage", 2, "1TB External Solid State Drive. Transfer massive files in seconds with USB 3.2 Gen 2. Shock-resistant and secure.", "Samsung T7 SSD", 4800.0, 50 },
                    { 9, "Electronics", 2, "Tenkeyless RGB mechanical gaming keyboard with blue switches for tactile feedback. Built with an aircraft-grade aluminum frame.", "Mechanical Keyboard", 3200.0, 20 },
                    { 10, "Appliances", 2, "1.7L stainless steel kettle with rapid boil technology and automatic shut-off feature for safety. Modern minimalist design.", "Electric Kettle", 1800.0, 100 },
                    { 11, "Electronics", 3, "Powerful portable Bluetooth speaker with IP67 waterproof and dustproof rating. Delivers loud, crystal clear sound anywhere.", "JBL Flip 6", 4500.0, 22 },
                    { 12, "Appliances", 3, "Semi-automatic espresso machine with a high-pressure pump and built-in milk frother. Perfect for lattes and cappuccinos.", "Coffee Maker", 7500.0, 8 },
                    { 13, "Accessories", 3, "Anti-theft business backpack with hidden zippers, integrated USB charging port, and water-repellent fabric.", "Backpack Antitheft", 2300.0, 60 },
                    { 14, "Electronics", 3, "Advanced smartwatch with health tracking, GPS, and a vibrant AMOLED display. Monitors heart rate, sleep, and blood oxygen levels.", "Smart Watch", 9000.0, 18 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_DepositoryId",
                table: "Products",
                column: "DepositoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Depositaries");
        }
    }
}
