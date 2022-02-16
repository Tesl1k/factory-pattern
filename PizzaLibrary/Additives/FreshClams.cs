using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary
{
    public class FreshClams : Clams
    {
        public Clams createClams()
        {
            return Pizza.clam;
        }
    }
}
