using System.Linq;
using ProductManager.Data;
using CalculationClasses;

namespace CalculationClasses
{
    public class DepositaryCalculations
    {
        private readonly DepositaryStorage _storage;

        public DepositaryCalculations(DepositaryStorage storage)
        {
            _storage = storage;
        }

        public decimal CalculateTotalStockValue()
        {
            // Calculate the sum (PricePerItem * quantity) for all products in the list of this warehouse
            return _storage.Products.Sum(p => p.PricePerItem * p.Quantity);
        }

        public string GetStorageHeader()
        {
            return $"\n>>> STORAGE: {_storage.Name} | LOCATION: {_storage.Location} <<<";
        }
    }
}