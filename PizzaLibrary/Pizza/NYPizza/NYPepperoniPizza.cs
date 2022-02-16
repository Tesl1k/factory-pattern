using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary
{
    class NYPepperoniPizza : Pizza
    {
        NYPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();
        public NYPepperoniPizza()
        {
            description = "Пицца пепперони";
            style = "Нью-Йорк";
        }
        public override string Prepare()
        {
            dough = ingredientFactory.createDough();
            sauce = ingredientFactory.createSauce();
            pepperoni = ingredientFactory.createPepperoni();
            return $"Добавлено: {dough}, {sauce}, {pepperoni}.\nПицца запечена";
        }

    }
}
