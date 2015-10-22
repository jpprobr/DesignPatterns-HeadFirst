using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Ex3
{
    /// <summary>
    /// Classe que cria um comportamento de vôo com um foguete
    /// </summary>
    public class FlyRocketPowered : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Pato voando com um foguete!");
        }
    }
}
