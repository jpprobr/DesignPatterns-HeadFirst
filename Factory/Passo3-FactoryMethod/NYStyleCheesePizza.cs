using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Passo3_FactoryMethod
{
    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            Name = "Pizza de Molho e Queijo de NY";
            Dough = "Massa fina";
            Sauce = "Molho marinara";

            Toppings.Add("Queijo ralado Reggiano");
        }
    }
}