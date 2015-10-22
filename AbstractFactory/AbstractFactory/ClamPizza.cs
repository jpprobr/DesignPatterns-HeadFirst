using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ClamPizza : Pizza
    {
        private IPizzaIngredientFactory _ingredientFactory;

        public ClamPizza(IPizzaIngredientFactory ingredientFactory)
        {
            this._ingredientFactory = ingredientFactory;
        }


        /// <summary>
        /// Coleta os ingredientes certos a partir da fábrica loca e prepara a pizza
        /// </summary>
        public void Prepare()
        {
            Console.WriteLine("Preparando " + Name);

            // Passa pela criação de uma pizza de queijo 
            // Toda vez que precisa de um ingrediente, pede para a fábrica produzi-lo
            Dough = this._ingredientFactory.CreateDough();
            Sauce = this._ingredientFactory.CreateSauce();
            Cheese = this._ingredientFactory.CreateCheese();
            Clam = this._ingredientFactory.CreateClam(); 

            // Os métodos Create serão chamados conforme a fábrica, 
            // Por ex.: Se for uma fábrica de Nova York a criação é de um jeito, se não será de outro jeito
        }
    }
}