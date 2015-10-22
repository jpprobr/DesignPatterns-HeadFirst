using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.Ex2.Interfaces;

namespace Strategy.Ex2.Classes
{
    /// <summary>
    /// Pato cabeça-vermelha
    /// </summary>
    class RedHeadDuck : Duck, IFlyable, IQuackable
    {
        public void Fly()
        {
            Console.WriteLine("Pato cabeça-vermelha voa...");
        }

        public void Quack()
        {
            Console.WriteLine("Pato cabeça-vermelha grasna...");
        }
    }
}