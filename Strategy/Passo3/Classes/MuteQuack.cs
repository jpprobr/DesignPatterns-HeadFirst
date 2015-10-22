using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Ex3
{
    public class MuteQuack :  IQuackBehavior
    {
        /// <summary>
        /// Implementação do silêncio dos patos
        /// </summary>
        public void MakeASound()
        {
            // Não faz nada - não emite som   
            Console.WriteLine("O pato não pode emitir som << Silêncio >>...");
        }
    }
}