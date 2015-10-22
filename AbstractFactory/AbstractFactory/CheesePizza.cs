using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class CheesePizza : Pizza
    {
        private IPizzaIngredientFactory _ingredientFactory;

        public CheesePizza(IPizzaIngredientFactory ingredientFactory)
        {
            this._ingredientFactory = ingredientFactory;
        }

        public void Prepare()
        {
            Console.WriteLine("Preparando " + Name);

            Dough = this._ingredientFactory.CreateDough(); // Massa fina
            Sauce = this._ingredientFactory.CreateSauce(); // Marinara
            Cheese = this._ingredientFactory.CreateCheese(); // Parmesão
        }
    }
}
