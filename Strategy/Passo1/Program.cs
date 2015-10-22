using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.Ex1.Classes;

namespace Strategy.Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pato Bravo
            MallardDuck md = new MallardDuck();
            md.Display();
            md.Swim();
            md.Fly();
            md.Quack();
            System.Console.WriteLine("\n");

            // Pato Cabeça-vermelha
            RedHeadDuck rhd = new RedHeadDuck();
            rhd.Display();
            rhd.Swim();
            rhd.Fly();
            rhd.Quack();
            System.Console.WriteLine("\n");

            // Pato de Borracha
            RubberDuck rd = new RubberDuck();
            rhd.Display();
            rhd.Swim();
            rd.Quack(); // Chia invés de grasnar
            System.Console.WriteLine("\n");

            Console.ReadKey();
        }
    }
}
