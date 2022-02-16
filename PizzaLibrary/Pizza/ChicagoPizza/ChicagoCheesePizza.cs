using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary
{
    class ChicagoCheesePizza : Pizza
    {
        ChicagoPizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();
        public ChicagoCheesePizza()
        {
            description = "Пицца c cыром";
            style = "Чикаго";
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
