using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Burger_Menu.Views
{
    public partial class MainWindow : Window
    {
        private readonly MainView _mainview = new();
        private readonly Drincks _drincks = new();
        private readonly Burgers _burger = new();

        private readonly MainTitle _maintitle = new MainTitle();
        private readonly BurgerTitle _burgertitle = new();
        private readonly DrinckTitle _drincktitle = new();
        public MainWindow()
        {
            InitializeComponent();
            PageConteiner.Content = _mainview;
            TitleContent.Content = _maintitle;
        }

        private void SwitchToMain(object sender, RoutedEventArgs e)
        {
            PageConteiner.Content = _mainview;
            TitleContent.Content = _maintitle;
        }
        private void SwitchToBurger(object sender, RoutedEventArgs e)
        {
            PageConteiner.Content = _burger;
            TitleContent.Content = _burgertitle;
        }
        private void SwitchToDrincks(object sender, RoutedEventArgs e)
        {
            PageConteiner.Content = _drincks;
            TitleContent.Content= _drincktitle;
        }
    }
}