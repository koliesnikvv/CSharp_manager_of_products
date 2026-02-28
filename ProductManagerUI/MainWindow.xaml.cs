using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
            Locator.Init();
            MainFrame.Navigate(new Pages.DepositaryPage());



        }
        public void toPage(Page page)
        {
            MainFrame.Navigate(page);
        }
        public void BackToPage()
        {
            if (MainFrame.CanGoBack)
            {
                MainFrame.GoBack();
            }
        }


    }
}