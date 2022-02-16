using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary
{
    public class CaliforniaPizzaStore : PizzaStore
    {

        public Pizza createPizza(string type)
        {
            Pizza pizza = null;

            switch (type)
            {
                case "Сыр":
                    pizza = new CaliforniaCheesePizza();
                    break;
                case "Моллюск":
                    pizza = new CaliforniaClamPizza();
                    break;
                case "Пепперони":
                    pizza = new CaliforniaPepperoniPizza();
                    break;
                case "Веган":
                    pizza = new CaliforniaVeggiePizza();
                    break;
            }

            return pizza;

        }
    }
}
