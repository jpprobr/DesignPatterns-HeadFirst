using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passo2
{
    /// <summary>
    /// Decorador: Whip (Creme)
    /// </summary>
    public class Whip : CondimentDecorator
    {

        private Beverage _beverage;


        public Whip(Beverage beverage)
        {
            this._beverage = beverage;
        }

        public override string GetDescription()
        {
            // Concatena a descrição acrescentando o condimento Whip
            return this._beverage.GetDescription() + ", Whip";
        }

        public override double Cost()
        {
            // Soma o custo do Whip com o custo da bebida
            return .10 + this._beverage.Cost();
        }
    }
}
