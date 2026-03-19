using System;
using System.Collections.Generic;
using System.Linq;
using ProductManager.Services;

namespace ProductManager.Services
{
    public class ProductDetailsDto
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
        public decimal TotalPrice => PricePerItem * Quantity;
        public string Description {
            get; set; 
        }
    }
}
