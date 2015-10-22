using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passo1
{
    public abstract class Beverage
    {
        protected string description;
        protected bool milk;
        protected bool soy;
        protected bool mocha;
        protected bool whip;

        //... (Entre outras variáveis...) 

        public double Cost()
        {
            var totalCost = 0;

            if (HasMilk())
                totalCost += 3;

            if (HasSoy())
                totalCost += 4;

            if (HasMocha())
                totalCost += 5;

            if (HasWhip())
                totalCost += 5;

            // Entre outras verificações...

            return totalCost;
        }


        public bool HasMilk()
        {
            return true;
        }

        public bool HasSoy()
        {
            return true;
        }

        public bool HasMocha()
        {
            return true;
        }

        public bool HasWhip()
        {
            return true;
        }

        //...
    }
}