namespace ProductManager.Services
{
    public class ProductListDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public decimal PricePerItem { get; set; }
        public int Quantity { get; set; }

        // Логіка розрахунку вартості цього товару (замість ProductsCalculations)
        public decimal TotalPrice => PricePerItem * Quantity;
    }
}