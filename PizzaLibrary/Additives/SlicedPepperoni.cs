using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary
{
    public class SlicedPepperoni : Pepperoni
    {
        public Pepperoni createPepperoni()
        {
            return Pizza.pepperoni;
        }
    }
}
