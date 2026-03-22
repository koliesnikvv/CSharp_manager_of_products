using System.Collections.ObjectModel;
using ProductManager.Services; 

namespace ProductManagerUI.ViewModels
{
    public class StorageDetailsViewModel : BaseViewModel
    {
        private readonly IDepositoryServices _service;

        private DepositoryDetailsDto _storage;
        public DepositoryDetailsDto Storage
        {
            get => _storage;
            set { _storage = value; OnPropertyChanged(); }
        }

        public StorageDetailsViewModel(IDepositoryServices service, int id)
        {
            _service = service;
            Storage = _service.GetDepositoryDetails(id);
        }
    }
}