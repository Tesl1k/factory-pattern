using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary
{
    public class SimplePizzaFactory
    {
        public Pizza createPizza(string type)
        {
            Pizza pizza = null;

            if (type == "Сыр")
            {
                pizza = new CheesePizza();
            }

            if (type == "Пепперони")
            {
                pizza = new PepperoniPizza();
            }

            if (type == "Моллюск")
            {
                pizza = new ClamPizza();
            }

            if (type == "Веган")
            {
                pizza = new VeggiePizza();
            }

            return pizza;
        }
    }
}
