using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Burger_Menu.Views.Pages.SecondPages
{

    public partial class Vopper : UserControl
    {
        public Vopper()
        {
            InitializeComponent();
            DataContext = new ViewModels.VopperViewModel(); // ”станавливаем контекст данных дл€ страницы Vopper
        }
    }
}