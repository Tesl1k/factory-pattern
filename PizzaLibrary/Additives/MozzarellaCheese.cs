using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary
{
    public class MozzarellaCheese : Cheese
    {
        public Cheese createCheese()
        {
            return Pizza.cheese;
        }
    }
}
