using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Магазин
{
    internal class Hardware : Product
    {
        public string Version { get; set; }

        private double basePrice;
        public override double Price => basePrice * 0.95;

        public Hardware(string name, double price, string version)
        {
            Name = name;
            basePrice = price;
            Version = version;
        }

        public override string GetInformation()
        {
            return $"Товар: {Name}, Версия: {Version} мл, Цена со скидкой: {Price}, Цена без скидки: {basePrice}";
        }
    }
}
