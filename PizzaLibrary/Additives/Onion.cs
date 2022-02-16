using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary
{
    public class Onion : Veggies
    {
        public Veggies[] createVeggies()
        {
            return Pizza.veggies;
        }
    }
}
