using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StorageClasses;

namespace CalculationClasses
{
    // Calc class for editing, creating and viewing depositaries
    public class DepositaryCalculations
    {
        private readonly DepositaryStorage _data;

        public DepositaryCalculations(DepositaryStorage data)
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

        public string Location
        {
            get
            {
                return _data.Location.ToString();
            }
        }

        // Calculation of the total cost of all products in this specific depositary
        public decimal TotalValue
        {
            get
            {
                // Returns 0 if there are no products, otherwise calculates the sum
                return _data.Products?.Sum(p => p.Price * p.Amount) ?? 0;
            }
        }

        public int ProductsCount
        {
            get
            {
                return _data.Products?.Count ?? 0;
            }
        }

        public string InformationAboutDepositary()
        {
            string information = $"Id of depositary: {Id}\n";
            information += $"Name of depositary: {Name}\n";
            information += $"Location: {Location}\n";
            information += $"Number of product types: {ProductsCount}\n";
            information += $"Total value of all products: {TotalValue}\n";
            return information;
        }
    }
}
//calc class for editing, creating and viewing depositarys