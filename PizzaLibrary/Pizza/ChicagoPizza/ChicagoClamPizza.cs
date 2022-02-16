using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary
{
    class ChicagoClamPizza : Pizza
    {
        ChicagoPizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();
        public ChicagoClamPizza()
        {            
            description = "Пицца с моллюсками";
            style = "Чикаго";
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
