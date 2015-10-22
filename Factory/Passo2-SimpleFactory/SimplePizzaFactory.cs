using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passo2_SimpleFactory
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(String type)
        {
            Pizza pizza = null;

            if (type.Equals("cheese"))
                pizza = new CheesePizza();
            if (type.Equals("pepperoni"))
                pizza = new PepperoniPizza();
            // etc.

            return pizza;
        }
    }
}
