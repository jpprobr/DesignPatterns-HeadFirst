using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passo3_FactoryMethod
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            if (type.Equals("cheese"))
                return new NYStyleCheesePizza();
            //if (type.Equals("veggie"))
            //    return new NYStyleVeggiePizza();
            //if (type.Equals("pepperoni"))
            //    return new NYStylePepperoniPizza();
            else
                return null;
        }
    }
}
