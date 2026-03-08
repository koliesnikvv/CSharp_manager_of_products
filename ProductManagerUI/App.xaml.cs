using System.Windows;

namespace ProductManagerUI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Initialize the IoC container before opening windows [cite: 20, 37]
            // This ensures Dependency Injection for the entire project [cite: 20, 37]
            Locator.Init();
        }
    }
}