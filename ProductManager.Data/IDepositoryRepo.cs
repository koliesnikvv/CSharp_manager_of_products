using System.Collections.Generic;
using ProductManager.Data; // Це обов'язково

namespace ProductManager.Data
{
    public interface IDepositoryRepo
    {
       // Замість IEnumerable<Depository> пиши DepositaryStorage

       IEnumerable<DepositaryStorage> GetAll();
        DepositaryStorage GetById(int id);
        void Add(DepositaryStorage depositary);
        void Delete(int id);
    }
}