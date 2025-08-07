using Burger_Menu.Models;
using Burger_Menu.ViewModels;
using Burger_Menu.Views;
using ReactiveUI;
using System;
using System.Reactive;

namespace Burger_Menu.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public VopperViewModel VopperVM { get; }
        private string _title;
        public string Title
        {
            get => _title;
            set => this.RaiseAndSetIfChanged(ref _title, value);
        }
        private ViewModelBase _currentView;
        public ViewModelBase CurrentView
        {
            get => _currentView;
            set => this.RaiseAndSetIfChanged(ref _currentView, value);
        }

        public ReactiveCommand<string, Unit> ChosePrise { get; }
        public ReactiveCommand<Unit, Unit> ShowMain { get; }
        public ReactiveCommand<Unit, Unit> ShowBurger { get; }
        public ReactiveCommand<Unit, Unit> ShowDrinck { get; }
        public ReactiveCommand<Unit, Unit> SwitchToOrder { get; }

        private string _price = "0"; // Переменная
        public string Price    // Поле
        {
            get => _price;
            set => this.RaiseAndSetIfChanged(ref _price, value); // Уведомляем интерфейс, при изменении поля
        }

        private string _Secondprice = "0"; // Переменная
        public string SecondPrice    // Поле
        {
            get => _Secondprice;
            set => this.RaiseAndSetIfChanged(ref _Secondprice, value); // Уведомляем интерфейс, при изменении поля
        }

        public MainWindowViewModel()
        {
            ChosePrise = ReactiveCommand.Create<string>(Calc);
            ShowMain = ReactiveCommand.Create(ShowMainView);
            ShowBurger = ReactiveCommand.Create(ShowBurgerView);
            ShowDrinck = ReactiveCommand.Create(ShowDrinckView);
            SwitchToOrder = ReactiveCommand.Create(ShowOrderView);
            CurrentView = new MainViewModel(this);
            Title = "Всё Меню";
            VopperVM = new VopperViewModel(this);
        }

        private void ShowMainView()
        {
            CurrentView = new MainViewModel(this);
            SecondPrice = "0"; 
            Title = "Всё Меню";
        }

        private void ShowOrderView()
        {
            CurrentView = new OrderViewModel();
            SecondPrice = "0";
            Title = "Заказ";
        }

        private void ShowBurgerView()
        {
            CurrentView = new BurgersViewModel(this);
            SecondPrice = "0";
            Title = "Бургеры";
        }

        private void ShowDrinckView()
        {
            CurrentView = new DrincksViewModel(this);
            SecondPrice = "0";
            Title = "Напитки";
        }
        public void AddView()
        {
            CurrentView = new MainViewModel(this);
            SecondPrice = "0";
            Title = "Всё Меню";
        }

        public void Calc(string name)
        {
            MenuPrice menu = new MenuPrice();
            Price = (Convert.ToDouble(Price) + menu.GetPrice(name)).ToString();
        }
        public void AddPrice()
        {
            Price = (Convert.ToDouble(Price) + Convert.ToDouble(SecondPrice)).ToString();
        }
        public void SecondCalc(string name)
        {
            MenuPrice Secondmenu = new MenuPrice();
            SecondPrice = (Convert.ToDouble(SecondPrice) + Secondmenu.GetSecondPrice(name)).ToString();
        }
    }
}