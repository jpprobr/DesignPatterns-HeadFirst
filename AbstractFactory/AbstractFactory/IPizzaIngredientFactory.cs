using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /// <summary>
    /// Interface que irá ajudar a definir quais ingredientes devem ser produzidos para criar uma Pizza
    /// </summary>
    public interface IPizzaIngredientFactory
    {
        public Dough CreateDough();

        public Sauce CreateSauce();

        public Cheese CreateCheese();

        public Veggie[] CreateVeggies();

        public Pepperoni CreatePepperoni();

        public Clam CreateClam();
    }
}
