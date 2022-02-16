using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary
{
    public class MarinaraSauce : Sauce
    {
        public Sauce createSauce()
        {
            return Pizza.sauce;
        }
    }
}
