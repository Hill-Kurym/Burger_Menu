﻿using Burger_Menu.Models;
using Burger_Menu.ViewModels;
using Burger_Menu.Views;
using ReactiveUI;
using System;
using System.Reactive;

namespace Burger_Menu.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
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

        private string _price = "0"; // Переменная
        public string Price    // Поле
        {
            get => _price;
            set => this.RaiseAndSetIfChanged(ref _price, value); // Уведомляем интерфейс, при изменении поля
        }


        public MainWindowViewModel()
        {
            ChosePrise = ReactiveCommand.Create<string>(Calc);
            ShowMain = ReactiveCommand.Create(ShowMainView);
            ShowBurger = ReactiveCommand.Create(ShowBurgerView);
            ShowDrinck = ReactiveCommand.Create(ShowDrinckView);

            CurrentView = new MainViewModel(this);
            Title = "Всё Меню";
        }

        private void ShowMainView()
        {
            CurrentView = new MainViewModel(this);
            Title = "Всё Меню";
        }

        private void ShowBurgerView()
        {
            CurrentView = new BurgersViewModel();
            Title = "Бургеры";
        }

        private void ShowDrinckView()
        {
            CurrentView = new DrincksViewModel();
            Title = "Напитки";
        }

        public void Calc(string name)
        {
            MenuPrice menu = new MenuPrice();
            Price = (Convert.ToDouble(Price) + menu.GetPrice(name)).ToString();
        }
    }
}