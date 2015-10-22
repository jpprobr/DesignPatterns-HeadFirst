using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passo2
{
    /// <summary>
    /// Mistura da Casa
    /// </summary>
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
        }

        public override string GetDescription()
        {
            return "House Blend Coffee";
        }

        public override double Cost()
        {
            return .89;
        }
    }
}