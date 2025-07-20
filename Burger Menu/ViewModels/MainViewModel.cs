using Burger_Menu.Models;
using Burger_Menu.Views;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;

namespace Burger_Menu.ViewModels
{
    public class MainViewModel:ViewModelBase
    {

        private MainWindowViewModel _mainWindow;

        public ReactiveCommand<string, Unit> ButtonClick { get; }
        public ReactiveCommand<Unit, Unit> ToVopper { get; }


        private string _price = "0"; // Переменная
        public string Price    // Поле
        {
            get => _price;
            set => this.RaiseAndSetIfChanged(ref _price, value); // Уведомляем интерфейс, при изменении поля
        }


        public MainViewModel(MainWindowViewModel mainWindow)
        {
            _mainWindow = mainWindow;
            ButtonClick = ReactiveCommand.Create<string>(Calc);
            ToVopper = ReactiveCommand.Create(ShowVopper);
        }

        private void ShowVopper()
        {
            _mainWindow.CurrentView = new VopperViewModel();
            _mainWindow.Title = "Воппер";
        }

        private void Calc(string name)
        {
            MenuPrice menu = new MenuPrice();
            Price = (Convert.ToDouble(Price) + menu.GetPrice(name)).ToString();
        }
    }
}
