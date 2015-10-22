using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passo2
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
           
        }

        public override string GetDescription()
        {
            return "Expresso";
        }

        /// <summary>
        /// Obtem o custo da bebida
        /// </summary>
        /// <returns></returns>
        public override double Cost()
        {
            return 1.99;
        }
    }
}