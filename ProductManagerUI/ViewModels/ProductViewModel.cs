using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagerUI.ViewModels
{
    using ProductManager.Services;

    namespace ProductManagerUI.ViewModels
    {
        public class ProductViewModel : ViewModelBase
        {
            private readonly IDepositoryService _service;

            // Конструктор, який приймає сервіс (тепер Locator буде задоволений)
            public ProductViewModel(IDepositoryService service)
            {
                _service = service;
            }
        }
    }
}