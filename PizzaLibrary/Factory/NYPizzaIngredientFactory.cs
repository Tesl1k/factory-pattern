using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary
{
    class NYPizzaIngredientFactory : PizzaIngredientFactory
    {
        public Dough createDough()
        {
            return new ThinCrustDough();
        }
        public Sauce createSauce()
        {
            return new MarinaraSauce();
        }
        public Cheese createCheese()
        {
            return new ReggianoCheese();
        }
        public Veggies[] createVeggies()
        {
            Veggies[] veggies = { new Onion(), new RedPepper() };
            return veggies;
        }
        public Pepperoni createPepperoni()
        {
            return new SlicedPepperoni();
        }
        public Clams createClam()
        {
            return new FreshClams();
        }
    }
}
