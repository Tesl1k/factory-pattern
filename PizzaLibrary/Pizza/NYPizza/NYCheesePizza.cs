using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary
{
    class NYCheesePizza : Pizza
    {
        NYPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();
        public NYCheesePizza()
        {           
            description = "Пицца c cыром";
            style = "Нью-Йорк";
        }
        public override string Prepare()
        {
            dough = ingredientFactory.createDough();
            sauce = ingredientFactory.createSauce();
            cheese = ingredientFactory.createCheese();
            return $"Добавлено: {dough}, {sauce}, {cheese}.\nПицца запечена";
        }

    }
}
