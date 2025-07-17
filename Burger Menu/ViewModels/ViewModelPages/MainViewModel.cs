using Burger_Menu.Models;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;

namespace Burger_Menu.ViewModels.ViewModelPages
{
    internal class MainViewModel: ViewModelBase
    {
        private string _price = "0"; // Переменная
        public string Price    // Поле
        {
            get => _price;
            set => this.RaiseAndSetIfChanged(ref _price, value); // Уведомляем интерфейс, при изменении поля
        }
        public ReactiveCommand<string, Unit> ButtonClick { get; }
        public MainViewModel()
        {
            ButtonClick = ReactiveCommand.Create<string>(Calc);
        }
        private void Calc(string name)
        {
            MenuPrice menu = new MenuPrice();
            Price = (Convert.ToDouble(Price) + menu.GetPrice(name)).ToString();
        }
    }
}
