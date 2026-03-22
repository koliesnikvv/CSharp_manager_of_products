using ProductManager.Data;
using ProductManager.Data;
using System.Collections.Generic;

namespace ProductManager.Data
{
    public class DepositoryStorage
    {
        private List<Depository> _depositories;

        public DepositoryStorage()
        {
            InitializeData();
        }

        private void InitializeData()
        {
            _depositories = new List<Depository>
            {
                new Depository
                {
                    Id = 1,
                    Name = "Kyiv Central Hub",
                    Location = DepositaryLocation.Kyiv,
                    Products = new List<Product>()
                },
                new Depository
                {
                    Id = 2,
                    Name = "Lviv Tech Warehouse",
                    Location = DepositaryLocation.Lviv,
                    Products = new List<Product>()
                },
                new Depository
                {
                    Id = 3,
                    Name = "Odesa Port Terminal",
                    Location = DepositaryLocation.Odesa,
                    Products = new List<Product>()
                }
            };
        }

        public List<Depository> GetAllDepositories() => _depositories;
        public Depository GetDepositoryById(int id) =>
            _depositories.FirstOrDefault(d => d.Id == id);
    }
}
   
//i didn't know another word to call склад sorry