using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passo2_SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {

            // Cria um objeto fábrica simples
            SimplePizzaFactory fabricaSimples = new SimplePizzaFactory();
            
            // Cria um objeto pizzaria
            PizzaStore pizzaria = new PizzaStore(fabricaSimples);



            // Faz um pedido
            Console.WriteLine("João pede uma pizza...\n");
            pizzaria.OrderPizza("cheese");


            Console.ReadKey();
        }
    }
}
