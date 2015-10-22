using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class Pizza
    {
        #region Propriedades

        public string Name;  // Nome 
        public Dough Dough; // Massa 
        public Sauce Sauce; // Molho 
        public Veggie[] Veggies; // Vegetais
        public Cheese Cheese;
        public Pepperoni Pepperoni;
        public Clam Clam;

        #endregion

        #region Métodos

        /// <summary>
        /// Método abstrato 
        /// </summary>
        public abstract void Prepare();
                    

        public void Bake()
        {
            Console.WriteLine("Assando a pizza...");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cortando a pizza...");
        }

        public void Box()
        {
            Console.WriteLine("Colocando a pizza em uma caixa oficial da PizzaStore...");
        }

        #endregion
    }
}