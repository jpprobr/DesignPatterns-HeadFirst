using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Ex2.Classes
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
    }
}