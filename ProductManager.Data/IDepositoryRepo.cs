using ProductManager.Data;
using System.Collections.Generic;

namespace ProductManager.Data
{
    public interface IDepositoryRepo
    {
        IEnumerable<Depository> GetAll();
        Depository GetById(int id);
    }
}
