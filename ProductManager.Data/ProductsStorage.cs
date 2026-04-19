using System.ComponentModel.DataAnnotations;

namespace ProductManager.Data
{
    public class ProductsStorage
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public double PricePerItem { get; set; }
        public int Quantity { get; set; }
        public int DepositoryId { get; set; }
        public virtual DepositaryStorage Depository { get; set; } = null!;
    }
}