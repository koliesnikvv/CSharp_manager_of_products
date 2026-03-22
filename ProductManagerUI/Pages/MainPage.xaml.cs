using System.Windows.Controls;
using ProductManager.Services; 
using ProductManagerUI.ViewModels; 

namespace ProductManagerUI.Pages
{
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            this.DataContext = new MainViewModel(Locator.DepositoryService);
        }

        private void WarehouseListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Now working with DTOs (DepositoryListDto) instead of database models
            if (WarehouseListBox.SelectedItem is DepositoryListDto selectedWarehouse)
            {
                NavigationService.Navigate(new StorageDetailsPage(selectedWarehouse.Id));
            }
        }
    }
}