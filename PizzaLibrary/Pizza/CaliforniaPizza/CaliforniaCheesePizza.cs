using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary
{
    class CaliforniaCheesePizza : Pizza
    {
        CaliforniaPizzaIngredientFactory ingredientFactory = new CaliforniaPizzaIngredientFactory();
        public CaliforniaCheesePizza()
        {
            description = "Пицца c cыром";
            style = "Калифорния";
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
