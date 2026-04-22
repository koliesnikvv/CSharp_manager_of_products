using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductManager.Data
{
    public class DepositaryStorage
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public virtual ICollection<ProductsStorage> Products { get; set; } = new List<ProductsStorage>();
    }
}