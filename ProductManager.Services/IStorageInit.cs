using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManager.Data;

namespace ProductManager.Services
{
    public interface IStorageInit
    {
        List<DepositaryStorage> Depositaries { get; }
        List<ProductsStorage> Products { get; }
    }
}
