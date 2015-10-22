using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passo2
{
    /// <summary>
    /// Decorador: Mocha (Moca)
    /// </summary>
    public class Mocha : CondimentDecorator
    {
        /// <summary>
        /// Variável de referência a Bebida
        /// </summary>
        Beverage _beverage;


        /// <summary>
        /// Maneira de definir a variável para o objeto que estamos englobando
        /// </summary>
        /// <param name="beverage"></param>
        public Mocha(Beverage beverage)
        {
            this._beverage = beverage;
        }

        public override string GetDescription()
        {
            // Concatena a descrição acrescentando o condimento Mocha
            return this._beverage.GetDescription() + ", Mocha";
        }

        public override double Cost()
        {
            // Soma o custo do Mocha com o custo da bebida
            return .20 + this._beverage.Cost();
        }
    }
}