using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passo2
{
     /// <summary>
     /// Programa StarbuzzCoffee
     /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Simulando o pedido de um Café Expresso sem condimentos
            Beverage b1 = new Espresso();
            Console.WriteLine(b1.GetDescription() + " - R$ " + b1.Cost());

            // Simulando o pedido de um Café DarkRoast com duplo Moca (chocolate) e creme
            Beverage b2 = new DarkRoast();
            b2 = new Mocha(b2);
            //b2 = new Mocha(b2);
            b2 = new Whip(b2);
            Console.WriteLine(b2.GetDescription() + " - R$ " + b2.Cost());

            // Simulando o pedido de um Café HouseBlend com Moca, soja e creme
            Beverage b3 = new HouseBlend();
            b3 = new Soy(b3);
            b3 = new Mocha(b3);
            b3 = new Whip(b3);
            Console.WriteLine(b3.GetDescription() + " - R$ " + b3.Cost());

            Console.ReadKey();

        }
    }
}
