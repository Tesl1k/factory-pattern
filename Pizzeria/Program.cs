using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaLibrary;

namespace Pizzeria
{
    class Program
    {
        static void Main(string[] args)
        {
            SimplePizzaFactory factory = new SimplePizzaFactory();
            PizzaStore pizza = new PizzaStore(factory);

            

            Console.WriteLine(pizza.orderPizza("Сыр").Display());
            Console.WriteLine(pizza.orderPizza("Пепперони").Display());
            Console.WriteLine(pizza.orderPizza("Моллюск").Display());
            Console.WriteLine(pizza.orderPizza("Веган").Display());

            Console.ReadKey();
        }
    }
}
