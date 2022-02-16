using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary
{
    public class ChicagoPizzaStore : PizzaStore
    {

        public Pizza createPizza(string type)
        {
            Pizza pizza = null;

            switch (type)
            {
                case "Сыр":
                    pizza = new ChicagoCheesePizza();
                    break;
                case "Моллюск":
                    pizza = new ChicagoClamPizza();
                    break;
                case "Пепперони":
                    pizza = new ChicagoPepperoniPizza();
                    break;
                case "Веган":
                    pizza = new ChicagoVeggiePizza();
                    break;
            }

            return pizza;

        }

    }
}
