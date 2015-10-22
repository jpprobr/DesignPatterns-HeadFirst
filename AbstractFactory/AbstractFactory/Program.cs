using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria uma pizzaria
            PizzaStore nyPizzaStore = new NYPizzaStore();

            // Faz um pedido (irá chamar o método CreatePizza)
            nyPizzaStore.OrderPizza("cheese");

            // 
        }
    }
}