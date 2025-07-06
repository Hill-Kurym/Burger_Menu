using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Burger_Menu.ViewModels;
using Burger_Menu.Views;

namespace Burger_Menu
{

    public partial class Burgers : Window
    {
        public Burgers()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }
        private void SwitchToDrincs(object sender, RoutedEventArgs e)
        {
            var drincsWindow = new Drincs();
            drincsWindow.Show();
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