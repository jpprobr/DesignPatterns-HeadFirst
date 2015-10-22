using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.Ex3;

namespace Strategy.Ex3
{
    public class FlyNoWay : IFlyBehavior
    {
        /// <summary>
        /// Implementação para todos os patos que não podem voar
        /// </summary>
        public void Fly()
        {
            // Fazer nada - não pode voar
            Console.WriteLine("O pato não pode voar!");
        }
    }
}