using System.Collections.Generic;
using System.Linq; 

namespace StorageClasses
{
    public class DepositaryStorage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DepositaryLocation Location { get; set; }
        public List<ProductsStorage> Products { get; set; }

        public decimal TotalValue => Products?.Sum(p => p.PricePerItem * p.Quantity) ?? 0;

        public DepositaryStorage(int id, string name, DepositaryLocation location)
        {
            Id = id;
            Name = name;
            Location = location;
            Products = new List<ProductsStorage>();
        }
    }
}