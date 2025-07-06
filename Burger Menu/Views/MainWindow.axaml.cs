using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Burger_Menu.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void SwitchToBurgers(object sender, RoutedEventArgs e)
        {
            var burgersWindow = new Burgers(); 
            burgersWindow.Show();
            this.Close();
        }
        private void SwitchToDrincs(object sender, RoutedEventArgs e)
        {
            var drincsWindow = new Drincs(); 
            drincsWindow.Show(); 
            this.Close();
        }
    }
}