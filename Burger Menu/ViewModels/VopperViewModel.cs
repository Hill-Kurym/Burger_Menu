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
    internal class VopperViewModel : ViewModelBase
    {
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
            AddToOrder = ReactiveCommand.Create<string>(name =>
            {
                _mainWindow.Calc(name);
            });
        }


    }
}
