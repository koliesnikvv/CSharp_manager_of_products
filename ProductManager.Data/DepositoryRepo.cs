using ProductManager.Data;
using System.Collections.Generic;

namespace ProductManager.Data
{
    public class DepositoryRepo : IDepositoryRepo
    {
        private readonly DepositoryStorage _storage;

        public DepositoryRepo()
        {
            _storage = new DepositoryStorage();
        }

        public IEnumerable<Depository> GetAll()
        {
            return _storage.GetAllDepositories();
        }

        public Depository GetById(int id)
        {
            return _storage.GetDepositoryById(id);
        }
    }
}