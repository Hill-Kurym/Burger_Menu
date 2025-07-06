using Burger_Menu.Models;
using ReactiveUI;
using System;
using System.Reactive;

namespace Burger_Menu.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string Greeting { get; } = "Welcome to Avalonia!";
    }
}
