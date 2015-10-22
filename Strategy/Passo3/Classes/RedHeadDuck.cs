using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Ex3
{
    /// <summary>
    /// Pato cabeça-vermelha
    /// </summary>
    public class RedHeadDuck : Duck
    {
        public RedHeadDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }
    }
}