using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary
{
    class ChicagoVeggiePizza : Pizza
    {
        ChicagoPizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();
        public ChicagoVeggiePizza()
        {
            description = "Пицца без мяса";
            style = "Чикаго";
        }
        public override string Prepare()
        {
            dough = ingredientFactory.createDough();
            sauce = ingredientFactory.createSauce();
            veggies = ingredientFactory.createVeggies();
            return $"Добавлено: {dough}, {sauce}, {veggies[0]}, {veggies[1]}.\nПицца запечена";
        }

    }
}
