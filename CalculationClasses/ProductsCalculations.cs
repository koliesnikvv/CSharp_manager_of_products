using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManager.Data;
//calc class for editing, creating and viewing products

namespace CalculationClasses
{
    public class ProductsCalculations
    {
        private readonly ProductsStorage _data;
        public ProductsCalculations(ProductsStorage data)
        {
            _data = data;
        }
        public int Id
        {
            get
            {
                return _data.Id;
            }
        }
        public string Name
        {
            get
            {
                return _data.Name;
            }
        }
        public int Quantity
        {
            get
            {
                return _data.Quantity;
            }
        }
        public decimal PricePerItem
        {
            get
            {
                return _data.PricePerItem;
            }
        }
        public string Description
        {
            get
            {
                return _data.Description;
            }
        }
        public string Category
        {
            get
            {
                return _data.Category.ToString();
            }
        }

        public decimal TotalPrice
        {
            get
            {
                return Quantity * PricePerItem;
            }
        }
        public int DepositaryId
        {
            get
            {
                return _data.DepositaryId;
            }
        }

        public string InformationAboutProduct()
        {
            string information = $"Id of product: {Id}";
            information += $"Name of product: {Name}\n";
            information += $"Description: {Description}\n";
            information += $"Category: {Category}\n";
            information += $"Left in storage -  {Quantity}\n";
            information += $"PricePerItem for one is  {PricePerItem}\n";
            information += $"Total PricePerItem is  {TotalPrice}\n";
            information += $"You can find this product on depositary  {DepositaryId}";
            return information;
        }
    }
}
