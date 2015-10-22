using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Ex1.Classes
{
    class DecoyDuck : Duck
    {
        public override void Quack()
        {
            // Substitui p/ fazer nada
        }

        public override void Fly()
        {
            // Substitui p/ fazer nada
        }
    }
}
