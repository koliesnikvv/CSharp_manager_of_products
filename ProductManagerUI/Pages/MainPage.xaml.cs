using System.Windows.Controls;
using StorageClasses;
using ServicesClasses;

namespace ProductManagerUI.Pages
{
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();

            // Using the correct method name from your ProcessingStorage
            if (Locator.DataService != null)
            {
                WarehouseListBox.ItemsSource = Locator.DataService.GetDepositaryStorages();
            }
        }

        private void WarehouseListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (WarehouseListBox.SelectedItem is DepositaryStorage selectedWarehouse)
            {
                // Navigate to Level 2: Storage Details and child entities
                NavigationService.Navigate(new StorageDetailsPage(selectedWarehouse));
            }
        }
    }
}