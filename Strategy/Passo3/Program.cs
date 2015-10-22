using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pato Bravo
            Duck mallard = new MallardDuck();
            mallard.Display();
            mallard.Swim(); 
 
            mallard.PerformQuack(); //Chama o método herdado de MallarDuck que depois delega p/ QuackBehavior do objeto 
            mallard.PerformFly();
            
            System.Console.WriteLine("\n");


            // Pato Cabeça-vermelha
            Duck redHead = new RedHeadDuck();
            redHead.Display();
            redHead.Swim();            
            redHead.PerformQuack();
            redHead.PerformFly();
            
            System.Console.WriteLine("\n");

            // Pato de Borracha
            Duck rubber = new RubberDuck();
            rubber.Display();
            rubber.Swim();
            rubber.PerformQuack();
            rubber.PerformFly();

            System.Console.WriteLine("\n");

            // Pato de Madeira
            Duck decoy = new DecoyDuck();
            decoy.Display();
            decoy.Swim();
            decoy.PerformQuack();
            decoy.PerformFly();

            System.Console.WriteLine("\n");


            // Model Duck
            Duck model = new Duck();
            model.PerformFly();
            model.SetFlyBehavior(new FlyRocketPowered());
            model.PerformFly();


            Console.ReadKey();
        }
    }
}