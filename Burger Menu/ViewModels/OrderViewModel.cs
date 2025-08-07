using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;
using Burger_Menu.Models;
using ReactiveUI;

namespace Burger_Menu.ViewModels
{
    public class OrderViewModel : ViewModelBase
    {
        private ObservableCollection<BurgerItem> _orders = new ObservableCollection<BurgerItem>();
        public ObservableCollection<BurgerItem> Orders
        {
            get => _orders;
            set => this.RaiseAndSetIfChanged(ref _orders, value);
        }
        public ReactiveCommand<BurgerItem, Unit> RemoveCommand { get; }

        public OrderViewModel()
        {
            RemoveCommand = ReactiveCommand.Create<BurgerItem>(item =>
            {
                Orders.Remove(item);
            });
        }
        public void AddBurgeer()
        {
            Orders.Add(new BurgerItem
            {
                Name = "Воппер",
                ImagePath = "/Assets/Burger and drinkc jpgs/Воппер.png",
                Price = 4.99
            });
        }
    }
}
