using System.Windows;
using System.Windows.Controls;
using StorageClasses;
using ServicesClasses;

namespace ProductManagerUI.Pages
{
    public partial class StorageDetailsPage : Page
    {
        public StorageDetailsPage(DepositaryStorage storage)
        {
            InitializeComponent();

            // Display information about the selected warehouse (1st level entity) [cite: 15, 33]
            StorageNameText.Text = storage.Name;
            StorageLocationText.Text = $"Location: {storage.Location}";

            // Load the list of products for this warehouse using the IoC service [cite: 18, 20, 21, 37]
            if (Locator.DataService != null)
            {
                ProductsListBox.ItemsSource = Locator.DataService.GetProductsByDepositaryId(storage.Id);
            }
        }

        // Logic for navigating to the 3rd level (Product details) [cite: 16, 33]
        private void ProductsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ProductsListBox.SelectedItem is ProductsStorage selectedProduct)
            {
                // Using page name ProductDetail
                NavigationService.Navigate(new ProductDetail(selectedProduct));
            }
        }

        // Implementation of the requirement to return to the previous page [cite: 17, 35]
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }
    }
}