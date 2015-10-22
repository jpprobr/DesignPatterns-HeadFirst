using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passo2
{
    /// <summary>
    /// Café de torra escura
    /// </summary>
    public class DarkRoast : Beverage
    {
        
        public DarkRoast()
        {
        }

        public override string GetDescription()
        {
            return "Dark Roast Coffee";
        }

        /// <summary>
        /// Obtem o custo da bebida
        /// </summary>
        /// <returns></returns>
        public override double Cost()
        {
            return .99;
        }
    }
}