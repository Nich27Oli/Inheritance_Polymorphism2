using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Polymorphism2.Entities
{
    internal class Product
    {
        public string Name { get; set; } = string.Empty;
        public double Price { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            return Name 
                + " $" 
                + Price.ToString();
        }

    }
}
