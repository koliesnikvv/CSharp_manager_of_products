using System.Collections.Generic;

namespace ProductManager.Data
{
    public class DepositaryStorage
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;

        // Навігаційна властивість
        public virtual ICollection<ProductsStorage> Products { get; set; } = new List<ProductsStorage>();
    }
}