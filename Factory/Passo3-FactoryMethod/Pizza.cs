using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passo3_FactoryMethod
{
    public abstract class Pizza
    {
        #region Propriedades

        public string Name;  // Nome 
        public string Dough; // Massa 
        public string Sauce; // Molho 
        public List<string> Toppings; // Coberturas 

        #endregion

        #region Construtor

        public Pizza()
        {
            // Inicializa a lista de coberturas
            this.Toppings = new List<string>();
        }

        #endregion

        #region Métodos

        public void Prepare()
        {
            Console.WriteLine("Preparando a pizza...");
        }

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