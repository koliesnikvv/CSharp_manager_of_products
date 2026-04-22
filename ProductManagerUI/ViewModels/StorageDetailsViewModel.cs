using System.Collections.ObjectModel;
using ProductManager.Data;
using ProductManager.Services;
using ProductManagerUI.ViewModels.ProductManagerUI.ViewModels;

namespace ProductManagerUI.ViewModels
{
    public class StorageDetailsViewModel : ViewModelBase
    {
        private readonly IDepositoryService _service;
        private DepositoryDetailsDto _storage;

        // Саме до цієї властивості прив'язаний твій XAML через {Binding Storage...}
        public DepositoryDetailsDto Storage
        {
            get => _storage;
            set { _storage = value; OnPropertyChanged(); }
        }

        public StorageDetailsViewModel(IDepositoryService service, int depositoryId)
        {
            _service = service;
            LoadData(depositoryId);
        }

        public void LoadData(int id)
        {
            // Отримуємо повні дані про склад разом із товарами
            Storage = _service.GetDepositoryById(id);
        }
    }
}