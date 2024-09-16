using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Магазин
{
    abstract class Product
    {
        public string Name { get; set; }
        public abstract double Price { get; }

        public abstract string GetInformation();
    }
}
