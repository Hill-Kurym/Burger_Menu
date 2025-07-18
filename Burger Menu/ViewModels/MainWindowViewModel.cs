﻿using Burger_Menu.Models;
using Burger_Menu.ViewModels.ViewModelPages;
using ReactiveUI;
using System;
using System.Reactive;

namespace Burger_Menu.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ViewModelBase _currentView;
        public ViewModelBase CurrentView
        {
            get => _currentView;
            set => this.RaiseAndSetIfChanged(ref _currentView, value);
        }

        public ReactiveCommand<string, Unit> ButtonClick { get; }

        private string _price = "0"; // Переменная
        public string Price    // Поле
        {
            get => _price;
            set => this.RaiseAndSetIfChanged(ref _price, value); // Уведомляем интерфейс, при изменении поля
        }


        public MainWindowViewModel()
        {
            ButtonClick = ReactiveCommand.Create<string>(Calc);
            CurrentView = new MainViewModel();
        }


        private void Calc(string name)
        {
            MenuPrice menu = new MenuPrice();
            Price = (Convert.ToDouble(Price) + menu.GetPrice(name)).ToString();
        }
    }
}