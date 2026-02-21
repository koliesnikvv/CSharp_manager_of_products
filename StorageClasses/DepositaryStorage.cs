using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StorageClasses
{
    public enum LocationEnum
    {
        Kyiv,
        Lviv,
        Boguslav,
        Odesa
    }

    public class DepositaryStorage
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

        // Collection of products belonging to this depositary
        public List<ProductsStorage> Products
        {
            get; set;
        }


        public DepositaryStorage(int id, string name)
        {
            Id = id;
            Name = name;
            Products = new List<ProductsStorage>();
        }

        public DepositaryStorage(int id, string name, LocationEnum location)
            : this(id, name)
        { }

        public DepositaryStorage(int id, string name, DepositaryLocation location)
            : this(id, name)
        {
            this.Location = location; 
        } 
    }
    }

//i didn't know another word to call склад sorry