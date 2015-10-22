using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Passo3_FactoryMethod
{
    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            Name = "Estilo de Pizza com queijo prato de Chicago";
            Dough = "Massa grossa";
            Sauce = "Molho de Tomate ameixa";

            Toppings.Add("Queijo mussarela ralado");
        }

        public override void Cut()
        {
            Console.WriteLine("Cortando a pizza em quadrados...");
        }
    }
}