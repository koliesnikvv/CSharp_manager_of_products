using System.Windows;
using ProductManagerUI.Pages; 

namespace ProductManagerUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Initialize the IoC container (data service)
            Locator.Init();

            //Open the first page (list of depositaries)
            MainFrame.Navigate(new MainPage());
        }
    }
}