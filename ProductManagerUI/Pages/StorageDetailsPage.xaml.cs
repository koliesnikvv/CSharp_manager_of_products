using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using ProductManager.Data; // Для доступу до моделей даних
using ProductManager.Services;
using ProductManagerUI.ViewModels;

namespace ProductManagerUI.Pages
{
    /// <summary>
    /// Логіка взаємодії для StorageDetailsPage.xaml
    /// </summary>
    public partial class StorageDetailsPage : Page
    {
        // Конструктор один і відповідає назві класу
        public StorageDetailsPage(int depositoryId)
        {
            InitializeComponent();

            // Встановлюємо DataContext через статичний Локатор у класі App
            // Передаємо ID складу, щоб отримати товари саме для нього
            this.DataContext = App.Locator.GetStorageDetailsViewModel(depositoryId);
        }

        /// <summary>
        /// Обробник для кнопки "Назад"
        /// </summary>
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }

        /// <summary>
        /// Метод, якого не вистачало в XAML для ListBox
        /// </summary>
        private void ProductsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ProductsListBox.SelectedItem is ProductListDto selectedProduct)
            {
                // Переходимо на сторінку деталей, передаючи вибраний продукт
                NavigationService.Navigate(new ProductDetailPage(selectedProduct));

                // Скидаємо виділення, щоб при поверненні можна було клікнути знову
                ProductsListBox.SelectedItem = null;
            }
        }
    }
}