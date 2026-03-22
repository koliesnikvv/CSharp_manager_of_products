using System.Collections.Generic;
using System.Linq;
using StorageClasses; 

namespace ProductManager.Data
{
    public class DepositoryRepo : IDepositoryRepo
    {
        public IEnumerable<DepositaryStorage> GetAll() => StarterStorage.Depositaries;

        public DepositaryStorage GetById(int id) =>
            StarterStorage.Depositaries.FirstOrDefault(d => d.Id == id);
    }
}