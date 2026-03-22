using ProductManager.Services;

namespace ProductManager.Services
{
    public class ProductListDto
    {
        public int Id {
            get; set; 
        }
        public string Name {
            get; set; 
        }
        public string Category { 
            get; set; 
        }
        public decimal PricePerItem {
            get; set; 
        }
        public int Quantity { 
            get; set; 
        }
        public string Description { 
            get; set; 
        }
        public decimal TotalPrice => PricePerItem * Quantity;
    }
}
