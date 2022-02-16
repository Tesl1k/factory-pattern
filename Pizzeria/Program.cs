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
            PizzaStore NYPizza = new NYPizzaStore();
            PizzaStore ChicagoPizza = new ChicagoPizzaStore();
            PizzaStore CaliforniaPizza = new CaliforniaPizzaStore();

            Console.WriteLine(NYPizza.createPizza("Сыр").Display());
            Console.WriteLine(ChicagoPizza.createPizza("Сыр").Display());
            Console.WriteLine(CaliforniaPizza.createPizza("Сыр").Display());

            Console.WriteLine(NYPizza.createPizza("Моллюск").Display());
            Console.WriteLine(ChicagoPizza.createPizza("Моллюск").Display());
            Console.WriteLine(CaliforniaPizza.createPizza("Моллюск").Display());

            Console.WriteLine(NYPizza.createPizza("Пепперони").Display());
            Console.WriteLine(ChicagoPizza.createPizza("Пепперони").Display());
            Console.WriteLine(CaliforniaPizza.createPizza("Пепперони").Display());

            Console.WriteLine(NYPizza.createPizza("Веган").Display());
            Console.WriteLine(ChicagoPizza.createPizza("Веган").Display());
            Console.WriteLine(CaliforniaPizza.createPizza("Веган").Display());

            Console.ReadKey();
        }
    }
}
