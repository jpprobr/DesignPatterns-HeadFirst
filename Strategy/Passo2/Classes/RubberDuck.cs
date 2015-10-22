using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.Ex2.Interfaces;

namespace Strategy.Ex2.Classes
{
    /// <summary>
    /// Pato de Borracha (Não deve voar)
    /// </summary>
    class RubberDuck : Duck, IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Pato de borracha chia (ao invés) de grasnar...");
        }
    }
}