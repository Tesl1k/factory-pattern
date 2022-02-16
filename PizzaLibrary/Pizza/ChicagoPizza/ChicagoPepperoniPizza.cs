using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary
{
    class ChicagoPepperoniPizza : Pizza
    {
        ChicagoPizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();
        public ChicagoPepperoniPizza()
        {
            description = "Пицца пепперони";
            style = "Чикаго";
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
