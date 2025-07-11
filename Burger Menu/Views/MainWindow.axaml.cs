using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Burger_Menu.Views
{
    public partial class MainWindow : Window
    {
        private readonly MainView _mainview = new();
        private readonly Drincks _drincks = new();
        private readonly Burgers _burger = new();
        public MainWindow()
        {
            InitializeComponent();
            PageConteiner.Content = _mainview;
        }

        private void SwitchToMain(object sender, RoutedEventArgs e)
        {
            PageConteiner.Content = _mainview;
        }
        private void SwitchToBurger(object sender, RoutedEventArgs e)
        {
            PageConteiner.Content = _burger;
        }
        private void SwitchToDrincks(object sender, RoutedEventArgs e)
        {
            PageConteiner.Content = _drincks;
        }
    }
}