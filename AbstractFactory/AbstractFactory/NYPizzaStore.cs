using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            // Define qual é a fábrica de ingredientes
            IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

            if (type.Equals("cheese"))
            {
                // Cria uma instancia de pizza passando a fábrica de ingredientes definida (Ex.: Nova York)
                pizza = new CheesePizza(ingredientFactory);
                pizza.Name = "Pizza de Queijo no estilo Nova York";
            }
            else if (type.Equals("clam"))
            {
                pizza = new ClamPizza(ingredientFactory);
                pizza.Name = "Pizza de Mariscos no estilo Nova York";
            }
            // etc.
                        
            return pizza;
        }
    }
}
