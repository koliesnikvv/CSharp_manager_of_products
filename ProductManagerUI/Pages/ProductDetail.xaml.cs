using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using ProductManagerUI.ViewModels;

namespace ProductManagerUI.Pages
{
    // 1. Назва класу МАЄ бути ProductDetail, щоб відповідати файлу .xaml
    public partial class ProductDetail : Page
    {
        // 2. Конструктор теж перейменовуємо на ProductDetail
        public ProductDetail(int productId)
        {
            InitializeComponent();

            // Якщо у тебе є окрема в'юмодель для деталей товару в Локаторі:
            // this.DataContext = App.Locator.GetProductViewModel(productId);

            // Якщо ж ця сторінка — це просто помилково названа сторінка складу, 
            // то краще взагалі видалити цей файл і користуватися StorageDetailsPage.
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