using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary
{
    public class ThinCrustDough : Dough
    {       

        public Dough createDough()
        {
            return Pizza.dough;
        }
    }
}
