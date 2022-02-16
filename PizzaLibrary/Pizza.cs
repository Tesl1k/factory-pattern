using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary
{
    abstract public class Pizza
    {
        string display;
        protected string description;

        string Bake()
        {
            return "Пицца испечена";
        }

        string Box()
        {
            return "Пицца упакована";
        }

        string Cut()
        {
            return "Пицца нарезана";
        }

        string Prepare()
        {
            return "Пицца подготовлена";
        }

        public string Display()
        {
            return display = $"{description}:\n{Prepare()}\n{Bake()}\n{Cut()}\n{Box()}\n";
        }
    }
}
