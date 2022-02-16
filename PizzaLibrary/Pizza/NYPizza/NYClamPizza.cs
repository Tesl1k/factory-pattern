using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary
{
    class NYClamPizza : Pizza
    {
        NYPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

        public NYClamPizza()
        {            
            description = "Пицца с моллюсками";
            style = "Нью-Йорк";
        }
        public override string Prepare()
        {
            dough = ingredientFactory.createDough();
            sauce = ingredientFactory.createSauce();
            clam = ingredientFactory.createClam();
            return $"Добавлено: {dough}, {sauce}, {clam}.\nПицца запечена";
        }

    }
}
