using System.Windows.Controls;
using System.Windows.Navigation;
using ProductManager.Data; // Додано для доступу до DepositoryListDto
using ProductManager.Services;
using ProductManagerUI.ViewModels;

namespace ProductManagerUI.Pages
{
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();

            // Встановлюємо DataContext через наш статичний Локатор
            this.DataContext = App.Locator.MainViewModel;
        }

        private void WarehouseListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Перевіряємо, чи вибраний елемент є DTO ( DepositoryListDto )
            if (WarehouseListBox.SelectedItem is DepositoryListDto selectedWarehouse)
            {
                // Переходимо на сторінку деталей, передаючи Id складу
                NavigationService.Navigate(new StorageDetailsPage(selectedWarehouse.Id));

                // Скидаємо вибір, щоб при поверненні назад можна було знову натиснути на той самий склад
                WarehouseListBox.SelectedItem = null;
            }
        }
    }
}