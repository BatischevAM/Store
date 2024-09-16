using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Магазин
{
    internal class Toy : Product
    {
        public int AgeRecommendation { get; set; }

        private double basePrice;
        public override double Price => basePrice * 0.9;

        public Toy(string name, double price, int ageRecommendation)
        {
            Name = name;
            basePrice = price;
            AgeRecommendation = ageRecommendation;
        }

        public override string GetInformation()
        {
            return $"Товар: {Name}, Рекомендуемый возраст: {AgeRecommendation}, Цена со скидкой: {Price}, Цена без скидки: {basePrice}";
        }
    }
}
