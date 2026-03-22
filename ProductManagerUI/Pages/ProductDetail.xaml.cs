using System.Windows;
using System.Windows.Controls;
using ProductManagerUI.ViewModels; 

namespace ProductManagerUI.Pages
{
    public partial class ProductDetail : Page
    {
        public ProductDetail(int productId)
        {
            InitializeComponent();

            // Setting the DataContext
            this.DataContext = new ProductViewModel(Locator.DepositoryService, productId);
        }

        //Back button(navigation)
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }
    }
}