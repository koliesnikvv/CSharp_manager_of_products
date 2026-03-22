using System.Collections.ObjectModel;
using ProductManager.Services; 

namespace ProductManagerUI.ViewModels
{
    // Inheriting from BaseViewModel to enable PropertyChanged
    public class MainViewModel : BaseViewModel
    {
        private readonly IDepositoryServices _depositoryService;

        // A specialized UI collection. The UI updates automatically when it changes.
        public ObservableCollection<DepositoryListDto> Depositories { get; set; }

        public MainViewModel(IDepositoryServices depositoryService)
        {
            _depositoryService = depositoryService;

            var data = _depositoryService.GetAllDepositories();

            Depositories = new ObservableCollection<DepositoryListDto>(data);
        }
    }
}