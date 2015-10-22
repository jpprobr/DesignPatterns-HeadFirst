using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passo1
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            description = "O café mais forte!";
        }

        public double Cost()
        {
            double costEspresso = 5;

            double totalCost = base.Cost() + costEspresso;

            return totalCost;
        }
    }
}