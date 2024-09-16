using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Магазин
{
    internal class Clothing : Product
    {
        public string Size { get; set; }

        private double basePrice;
        public override double Price => basePrice * 0.8;

        public Clothing(string name, double price, string size)
        {
            Name = name;
            basePrice = price;
            Size = size;
        }

        public override string GetInformation()
        {
            return $"Товар: {Name}, Размер: {Size}, Цена со скидкой: {Price}, Цена без скидки: {basePrice}";
        }
    }
}
