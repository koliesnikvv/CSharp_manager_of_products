using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using ProductManager.Data;
using ProductManager.Services;
using ProductManagerUI.ViewModels;
using ProductManagerUI.ViewModels.ProductManagerUI.ViewModels;

namespace ProductManagerUI.ViewModels
{
    /// <summary>
    /// ViewModel для головної сторінки, що відображає список складів.
    /// Наслідується від ViewModelBase для підтримки оновлення інтерфейсу.
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private readonly IDepositoryService _service;
        private DepositoryListDto _selectedDepository;

        // Колекція складів, до якої прив'язаний ListBox у XAML
        public ObservableCollection<DepositoryListDto> Depositories { get; set; } = new();

        /// <summary>
        /// Вибраний склад у списку. 
        /// (Корисно, якщо ти захочеш обробляти вибір через Binding, а не SelectionChanged)
        /// </summary>
        public DepositoryListDto SelectedDepository
        {
            get => _selectedDepository;
            set
            {
                _selectedDepository = value;
                OnPropertyChanged(); // Сповіщаємо інтерфейс про зміну
            }
        }

        public MainViewModel(IDepositoryService service)
        {
            _service = service;

            // Завантажуємо дані при створенні ViewModel
            LoadData();
        }

        /// <summary>
        /// Метод для завантаження даних із бази SQLite через сервіс.
        /// </summary>
        public void LoadData()
        {
            try
            {
                // Отримуємо актуальний список DTO із сервісу
                var data = _service.GetAllDepositories();

                // Обов'язково очищуємо колекцію перед додаванням нових даних
                Depositories.Clear();

                if (data != null)
                {
                    foreach (var item in data)
                    {
                        Depositories.Add(item);
                    }
                }

                // Логування для перевірки в Output, якщо список порожній
                if (Depositories.Count == 0)
                {
                    System.Diagnostics.Debug.WriteLine("MainViewModel: База даних повернула порожній список.");
                }
            }
            catch (Exception ex)
            {
                // Виводимо помилку в консоль відладки, якщо щось пішло не так з SQLite
                System.Diagnostics.Debug.WriteLine($"MainViewModel Error: {ex.Message}");
                MessageBox.Show("Помилка при завантаженні даних із бази SQLite.");
            }
        }
    }
}