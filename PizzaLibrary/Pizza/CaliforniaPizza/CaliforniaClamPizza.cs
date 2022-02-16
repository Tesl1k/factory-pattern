using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary
{
    class CaliforniaClamPizza : Pizza
    {
        CaliforniaPizzaIngredientFactory ingredientFactory = new CaliforniaPizzaIngredientFactory();
        public CaliforniaClamPizza()
        {
            description = "Пицца c cыром";
            style = "Калифорния";
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
