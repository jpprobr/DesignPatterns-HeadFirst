using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /// <summary>
    /// Classe Abstrata PizzaStore
    /// </summary>
    public abstract class PizzaStore
    {
        /// <summary>
        /// Método padrão p/ processar o pedido da Pizza
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public Pizza OrderPizza(String type)
        {
            // Chama o método fábrica de uma subclasse () 
            Pizza pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        /// <summary>        
        /// Método Factory (Factory Method) abstrato a ser implementado pelas SubClasses (franquias)
        /// As subclasses tem que lidar com a criação de objetos
        /// </summary>
        /// <param name="type"></param>
        /// <returns>Um método factory retorna um 'Produto'</returns>
        protected abstract Pizza CreatePizza(String type);
    }
}