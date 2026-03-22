using System.Collections.Generic;
using ProductManager.Data;
using StorageClasses;

namespace ProductManager.Data
{
    public interface IDepositoryRepo
    {
        IEnumerable<DepositaryStorage> GetAll();
        DepositaryStorage GetById(int id);
    }
}
