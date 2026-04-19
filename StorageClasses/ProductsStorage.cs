namespace ProductManager.Data
{
    public class ProductsStorage
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public double PricePerItem { get; set; }
        public int Quantity { get; set; }

        // ДОДАЙ ЦЕ ПОЛЕ (перевір написання: DepositoryId чи DepositaryId)
        // Якщо в AppDbContext ти пишеш DepositoryId, то і тут має бути так само:
        public int DepositoryId { get; set; }

        // Навігаційна властивість
        public virtual DepositaryStorage Depository { get; set; } = null!;
    }
}