using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passo2
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
           
        }

        public override string GetDescription()
        {
            return "Decaf Coffee";
        }

        public override double Cost()
        {
            return 1.05;
        }
    }
}