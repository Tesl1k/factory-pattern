using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary
{
    public class ChicagoPizzaIngredientFactory : PizzaIngredientFactory
    {
        public Dough createDough()
        {
            return new ThickCrustDough();
        }
        public Sauce createSauce()
        {
            return new PlumTomatoSauce();
        }
        public Cheese createCheese()
        {
            return new MozzarellaCheese();
        }
        public Veggies[] createVeggies()
        {
            Veggies[] veggies = { new Garlic(), new Mushroom() };
            return veggies;
        }
        public Pepperoni createPepperoni()
        {
            return new SlicedPepperoni();
        }
        public Clams createClam()
        {
            return new FrozenClams();
        }
    }
}
