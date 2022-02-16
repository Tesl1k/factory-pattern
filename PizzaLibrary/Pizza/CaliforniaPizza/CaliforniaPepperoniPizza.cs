using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary
{
    class CaliforniaPepperoniPizza : Pizza
    {
        CaliforniaPizzaIngredientFactory ingredientFactory = new CaliforniaPizzaIngredientFactory();
        public CaliforniaPepperoniPizza()
        {
            description = "Пицца пепперони";
            style = "Калифорния";
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
