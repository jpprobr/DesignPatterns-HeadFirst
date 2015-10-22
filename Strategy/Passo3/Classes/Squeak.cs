using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Ex3
{
    public class Squeak : IQuackBehavior
    {
        /// <summary>
        /// Implementação do guingar (chiar) dos patos
        /// </summary>
        public void MakeASound()
        {
            // Implementa o guinchar dos patos
            Console.WriteLine("O pato guincha (Squeak)...");
        }
    }
}