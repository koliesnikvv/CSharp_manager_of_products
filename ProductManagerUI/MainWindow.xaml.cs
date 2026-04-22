using System;
using System.Windows;
using ProductManagerUI.Pages;

namespace ProductManagerUI
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            try
            {
                // Пробуємо завантажити головну сторінку у Frame
                MainFrame.Navigate(new MainPage());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при переході на MainPage: {ex.Message}");
            }
        }
    }
}