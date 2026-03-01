using System.Windows;
using System.Windows.Controls;
using StorageClasses;

namespace ProductManagerUI.Pages
{
    public partial class ProductDetail : Page
    {
        // The designer accepts the selected product
        public ProductDetail(ProductsStorage product)
        {
            InitializeComponent();

            // Fill the interface with data from Lab1
            ProductNameText.Text = product.Name;
            CategoryText.Text = $"Category: {product.Category}";
            PriceText.Text = $"Price: {product.Price} uah";
            AmountText.Text = $"Quantity: {product.Amount} pieces.";
            DescriptionText.Text = product.Description ?? "There is no description";
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack(); // Return to the previous page
            }
        }
    }
}