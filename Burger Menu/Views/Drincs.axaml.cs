using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Burger_Menu.ViewModels;
using Burger_Menu.Views;

namespace Burger_Menu
{

    public partial class Drincs : Window
    {
        public Drincs()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }
        private void SwitchToBurgers(object sender, RoutedEventArgs e)
        {
            var burgersWindow = new Burgers();
            burgersWindow.Show();
            this.Close();
        }

        private void SwitchToMain(object sender, RoutedEventArgs e)
        {
            var mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}