using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StorageClasses
{
   
    public class ProductsStorage
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        [ForeignKey("DepositaryStorage")]
        public int DepositaryId { get; set; }

        [Column(TypeName ="decimal (18,2)")]
        public decimal PricePerItem { get; set; } 
        public int Quantity { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }
        public ProductsCategory Category { get; set; }
        public virtual DepositaryStorage Depositary { get; set; }

        public ProductsStorage() { }
        public ProductsStorage(int id, string name) { Id = id; Name = name; }
    }
}