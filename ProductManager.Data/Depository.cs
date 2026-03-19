using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager.Data
{
    public class Depository
    {
        public int Id
        {
            get; set;
        }
        public string Name
        {
            get; set;
        }
        public DepositaryLocation Location
        {
            get; set;
        }
        public List<Product> Products { get; set; } = new List<Product>();
        public decimal TotalValue => Products?.Sum(p => p.TotalPrice) ?? 0;

    }
}