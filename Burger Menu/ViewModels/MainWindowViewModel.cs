using Burger_Menu.Models;
using ReactiveUI;
using System;
using System.Reactive;

namespace Burger_Menu.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string Greeting { get; } = "Welcome to Avalonia!";



        /// <summary>
        ///  Инициализация команды. 
        ///  Изменил тип передаваемого значения с общего на строковый 
        ///  Теперь при использовании command можно добавить параметр ( строку )
        /// </summary>
        public ReactiveCommand<string, Unit> ButtonClick { get; }



        /// <summary>
        /// Определяем переменную для вывода итогового ценника
        /// Обязательно используем паттерн MVVM для обеспечения доступа к локальной переменной
        /// Не забывает пользоваться функциями ReactiveUI для обновления интерфейса. Метод RaiseAndSetIfChanged - 
        ///    - вызывает Notice и уведомляет интерфейс о необходимости перерисоваться
        /// </summary>
        private string _price = "0"; // Переменная
        public string Price    // Поле
        {
            get => _price;
            set => this.RaiseAndSetIfChanged(ref _price, value); // Уведомляем интерфейс, при изменении поля
        }



        /// <summary>
        /// В конструторе класса мы всегда инициализируем комманды ( крайне редко нет )
        /// Тк он имеет высокое место в иерархии вызовов и вызывается до отрисовки UI. Так же можно использовать конструктор cs файла страницы
        /// </summary>
        public MainWindowViewModel()
        {
            /// Логика должна быть вынесена на model
            /// ButtonClick = ReactiveCommand.Create<string>(метод);
            /// Но если работа слишком маленькая ( изменение локальной переменной ), то можно и выполнить ее во ViewModel
            ButtonClick = ReactiveCommand.Create<string>(Calc);

        }


        
        /// <summary>
        /// Вот уже наше имя продукта попадает в метод логики. Я разместил его во ViewModel, тк он слишком маленький.
        /// </summary>
        /// <param name="name"></param>
        private void Calc(string name)
        {
            MenuPrice menu = new MenuPrice();

            Price = (Convert.ToDouble(Price) + menu.GetPrice(name)).ToString();
        }
    }
}
