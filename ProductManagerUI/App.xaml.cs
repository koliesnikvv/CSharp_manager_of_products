using System.Windows;

namespace ProductManagerUI
{
    public partial class App : Application
    {
        // Створюємо статичний екземпляр Локатора відразу при запуску
        private static Locator _locator;

        public static Locator Locator
        {
            get
            {
                if (_locator == null)
                    _locator = new Locator();
                return _locator;
            }
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Глобальна обробка помилок (допоможе відловити проблеми з SQLite)
            this.DispatcherUnhandledException += (s, args) =>
            {
                MessageBox.Show($"Критична помилка: {args.Exception.Message}", "Помилка додатка", MessageBoxButton.OK, MessageBoxImage.Error);
                args.Handled = true;
            };
        }
    }
}