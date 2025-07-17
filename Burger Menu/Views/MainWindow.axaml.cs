using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Burger_Menu.Views
{
    public partial class MainWindow : Window
    {
        private readonly MainView mainView = new();
        private readonly MainTitle _maintitle = new MainTitle();
        private readonly BurgerTitle _burgertitle = new();
        private readonly DrinckTitle _drincktitle = new();
        public MainWindow()
        {
            InitializeComponent();
            TitleContent.Content = _maintitle;
            PageContainer.Content = mainView;
        }
    }
}