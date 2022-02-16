using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary
{
    abstract public class Pizza
    {
        
        public static Dough dough;
        public static Sauce sauce;
        public static Veggies[] veggies;
        public static Cheese cheese;
        public static Pepperoni pepperoni;
        public static Clams clam;

        string display;
        public string description;
        public string style;

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

        public abstract string Prepare();

        public string Display()
        {
            return display = $"{description}:\n{Prepare()}\n{Bake()}\n{Cut()}\n{Box()}\nСтиль: {style}\n";
        }
    }
}
