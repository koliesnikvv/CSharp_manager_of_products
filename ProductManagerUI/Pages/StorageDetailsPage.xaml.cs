using System.Windows;
using System.Windows.Controls;
using ProductManager.Services; 
using ProductManagerUI.ViewModels;

namespace ProductManagerUI.Pages
{
    public partial class StorageDetailsPage : Page
    {
        public StorageDetailsPage(int depositoryId)
        {
            InitializeComponent();

            // Establishing the ViewModel as the primary data source
            this.DataContext = new StorageDetailsViewModel(Locator.DepositoryService, depositoryId);
        }

        // Navigation to the 3-rd level (Product Details)
        private void ProductsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ProductsListBox.SelectedItem is ProductListDto selectedProduct)
            {
                NavigationService.Navigate(new ProductDetail(selectedProduct.Id));
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }
    }
}