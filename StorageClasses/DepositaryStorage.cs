using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;


namespace StorageClasses
{
    public class DepositaryStorage
    {
        [Key]
        public int Id {
            get; set;
        }

        [Required]
        [MaxLength(100)]
        public string Name {
            get; set;
        }

        public DepositaryLocation Location {
            get; set; 
        }
        public virtual ICollection<ProductsStorage> Products { get; set; } = new List<ProductsStorage>();
        [NotMapped]
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