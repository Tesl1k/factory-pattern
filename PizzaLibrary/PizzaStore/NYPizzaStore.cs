using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary
{
    public class NYPizzaStore : PizzaStore
    {        

        public Pizza createPizza(string type)
        {
            Pizza pizza = null;

            switch (type) 
            {
                case "Сыр":
                    pizza = new NYCheesePizza();
                    break;
                case "Моллюск":
                    pizza = new NYClamPizza();
                    break;
                case "Пепперони":
                    pizza = new NYPepperoniPizza();
                    break;
                case "Веган":
                    pizza = new NYVeggiePizza();
                    break;
            }

            return pizza;

        }

        
    }
}
