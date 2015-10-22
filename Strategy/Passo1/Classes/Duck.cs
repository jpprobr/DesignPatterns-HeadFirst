using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Ex1.Classes
{
    class Duck
    {       
        public void Swim()
        {
            System.Console.WriteLine("O pato nada...");
        }

        public void Display()
        {
            System.Console.WriteLine("O pato aparece...");
        }

        public virtual void Quack()
        {
            System.Console.WriteLine("O pato grasna...");
        }

        public virtual void Fly()
        {
            System.Console.WriteLine("O pato voa...");
        }
    }
}