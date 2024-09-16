using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Магазин
{
    internal class Drink : Product
    {
        public int Volume { get; set; }

        private double basePrice;
        public override double Price => basePrice * 0.95;

        public Drink(string name, double price, int volume)
        {
            Name = name;
            basePrice = price;
            Volume = volume;
        }

        public override string GetInformation()
        {
            return $"Товар: {Name}, Объем: {Volume} мл, Цена со скидкой: {Price}, Цена без скидки: {basePrice}";
        }
    }
}
