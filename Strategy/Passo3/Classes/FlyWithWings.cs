using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Ex3
{
    /// <summary>
    /// Implementação do voar para todos os patos com asas
    /// </summary>
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            // Implementa o voar dos patos
            Console.WriteLine("O pato voa...");
        }
    }
}