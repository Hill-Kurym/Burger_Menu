using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burger_Menu.Models
{
    public class MenuPrice
    {
        /// <summary>
        /// Создадим словарь для хранения названия продуктов и их стоимости.
        /// Приватный, чтобы было видно только изнутри класса. Другим классам нет нужды к нему обращаться
        /// Readonly, чтобы зафиксировать элементы словаря, без возможности изменить
        /// Ключ (string) - название продукта. Значение (double) - цена продукта
        /// Модификатор OrdinalIgnoreCase позволит обращаться к словарю без учета регистра
        /// </summary>
        private readonly Dictionary<string, double> _menu = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase)
        {
            // Сразу добавим элементы в наше меню. Является плохим практисом, но допустимо в маленьких проектах 
            ["Fries"] = 50,
            ["Vopper"] = 290,
            ["Cheeseburger"] = 250,
            ["Double Cheeseburger"] = 350,
            ["Chicken Burger"] = 300,
            ["Veggie Burger"] = 220,
            ["Milkshake"] = 150,
            ["Soda"] = 80,
            ["Water"] = 50,

            // Добавь сюда элементы, если хочешь расширить меню
        };

        /// <summary>
        /// Возвращает значение словаря по найденному ключу
        /// </summary>
        /// <param name="name">Ключ словаря</param>
        /// <returns></returns>
        public double? GetPrice(string name)
        {
            if (_menu.TryGetValue(name, out var price)) // Важно использовать Try ( TryGetValue, TryAdd, TryDequeue ), дабы не выносить exeption за пределы вызова
                return price;
            return null;
        }
    }
}