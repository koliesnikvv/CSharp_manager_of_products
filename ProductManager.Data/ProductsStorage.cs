using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
//obvious, storage for products

namespace ProductManager.Data
{
    public class ProductsStorage
    {
        public int Id
        {
            get; set;
        }
        public string Name
        {
            get; set;
        }
        public int Amount
        {
            get; set;
        }
        public decimal Price
        {
            get; set;
        }
        public string Description
        {
            get; set;
        }
        
        public int DepositaryId {
            get; set;
            }
        public ProductsCategory Category
        {
            get; set;
        }


        public ProductsStorage(int id, string name, int depositaryId)
        {
            Id = id; 
            Name = name;
            DepositaryId = depositaryId;

        }
        public ProductsStorage(int id, string name, int depositaryId, int amount, decimal price, string description, ProductsCategory category)
            : this(id, name, depositaryId)
        {
            Amount = amount;
            Price = price;
            Description = description;
            Category = category;
        }
    }
}
