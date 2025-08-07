using Burger_Menu.Views;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;
using Burger_Menu.Models;

namespace Burger_Menu.ViewModels
{
    public class VopperViewModel : ViewModelBase
    {
        private ReactiveCommand<string, Unit> _addtoorderfirst;
        public ReactiveCommand<string, Unit> AddToOrderFirst
        {
            get => _addtoorderfirst;
            set => this.RaiseAndSetIfChanged(ref _addtoorderfirst, value);
        }

        private ReactiveCommand<string, Unit> _addToOrder;
        public ReactiveCommand<string, Unit> AddToOrder
        {
            get => _addToOrder;
            set => this.RaiseAndSetIfChanged(ref _addToOrder, value);
        }


        private MainWindowViewModel _mainWindow;
        public VopperViewModel(MainWindowViewModel mainWindow)
        {
            _mainWindow = mainWindow;
            OrderViewModel orderViewModel = new OrderViewModel();
            AddToOrder = ReactiveCommand.Create<string>(name =>
            {
                _mainWindow.Calc(name);
                _mainWindow.AddPrice();
                _mainWindow.AddView();
            });
            AddToOrderFirst = ReactiveCommand.Create<string>(name =>
            {
                _mainWindow.SecondCalc(name);
            }
            );
        }
    }
}
