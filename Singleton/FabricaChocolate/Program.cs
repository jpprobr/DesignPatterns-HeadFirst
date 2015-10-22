using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaChocolate
{
    class Program
    {
        static void Main(string[] args)
        {
            // Simula a caldeira de chocolate
            ChocolateBoiler caldeira1 = new ChocolateBoiler();

            caldeira1.Fill(); // Enche
            caldeira1.Boil(); // Ferve
            caldeira1.Drain(); // Drena

            // Simulando a situação com mais de uma instancia
            // Ex.: Caso ocorra de ter 2 instancias (2 referências na memória)
            ChocolateBoiler caldeira2 = new ChocolateBoiler();

            caldeira1.Fill();
            caldeira2.Fill(); // Vai tentar encher de novo (mas vai parar na verificação) - E se não houvesse verificação!? :(            

            // Pode ser possível que uma instancia seja chamada antes de outra
            caldeira1.Boil();
            caldeira1.Drain();
            caldeira2.Drain();
            caldeira2.Boil();

            // Neste caso, a chamada dos métodos com mais de uma instancia pode interferir nos estados (variáveis) da caldeira
            // Ameaçando um funcionamento seguro da caldeira

            Console.ReadKey();
        }
    }
}
