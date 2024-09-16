using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Магазин
{
    internal class Meat : Product
    {
        public double Weight { get; set; }

        private double basePrice;
        public override double Price => basePrice * 0.85;

        public Meat(string name, double price, double weight)
        {
            Name = name;
            basePrice = price;
            Weight = weight;
        }

        public override string GetInformation()
        {
            return $"Товар: {Name}, Вес: {Weight} кг, Цена со скидкой: {Price}, Цена без скидки: {basePrice}";
        }
    }
}
