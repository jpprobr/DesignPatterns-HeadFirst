using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaChocolateSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // Simula a caldeira de chocolate
            ChocolateBoiler caldeira1 = ChocolateBoiler.GetInstance();

            caldeira1.Fill(); // Enche
            caldeira1.Boil(); // Ferve
            caldeira1.Drain(); // Drena
            Console.WriteLine("Qtde de instancias = " + ChocolateBoiler.QtdeInstancias);
            

            ChocolateBoiler caldeira2 = ChocolateBoiler.GetInstance();
            caldeira2.Fill(); // Enche
            caldeira2.Boil(); // Ferve
            caldeira2.Drain(); // Drena
            Console.WriteLine("Qtde de instancias = " + ChocolateBoiler.QtdeInstancias);

            //Teste Singleton


            Console.ReadKey();
        }
    }
}
