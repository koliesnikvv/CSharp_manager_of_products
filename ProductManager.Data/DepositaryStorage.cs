using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProductManager.Data
{


    public class DepositaryStorage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DepositaryLocation Location { get; set; }
        public List<ProductsStorage> Products { get; set; }

        public DepositaryStorage(int id, string name, DepositaryLocation location)
        {
            Id = id;
            Name = name;
            Location = location;
            Products = new List<ProductsStorage>();
        }
    }
}

//i didn't know another word to call склад sorry