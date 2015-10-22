using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Strategy.Ex3
{
    /// <summary>
    /// Pato de Borracha (Não deve voar)
    /// </summary>
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            quackBehavior = new Squeak();
            flyBehavior = new FlyNoWay();
        }
    }
}