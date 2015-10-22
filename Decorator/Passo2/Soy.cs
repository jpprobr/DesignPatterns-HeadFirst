using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passo2
{
    /// <summary>
    /// Decorador: Soy (Soja)
    /// </summary>
    public class Soy : CondimentDecorator
    {
        private Beverage _beverage;


        public Soy(Beverage beverage)
        {
            this._beverage = beverage;
        }

        public override string GetDescription()
        {
            // Concatena a descrição acrescentando o condimento Mocha
            return this._beverage.GetDescription() + ", Soy";
        }

        public override double Cost()
        {
            // Soma o custo do Soy com o custo da bebida
            return .15 + this._beverage.Cost();
        }
    }
}
