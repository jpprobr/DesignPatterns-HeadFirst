using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passo3_FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // Simulando a criação de Pizzas e pedidos

            // Cria 2 pizzarias diferentes
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();
            Console.WriteLine();

            // Adiciona um pedido de João
            Pizza pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine("João pediu uma " + pizza.Name + "\n");

            // Adiciona um pedido de Maria
            pizza = chicagoStore.OrderPizza("cheese");
            Console.WriteLine("Maria pediu uma " + pizza.Name + "\n");


            Console.ReadKey();
        }
    }
}
