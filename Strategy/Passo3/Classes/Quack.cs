using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.Ex3;

namespace Strategy.Ex3
{
    public class Quack : IQuackBehavior
    {
        /// <summary>
        /// Implementação do grasnar dos patos
        /// </summary>
        public void MakeASound()
        {
            // Implementa o grasnar dos patos
            Console.WriteLine("O pato grasna...");
        }
    }
}