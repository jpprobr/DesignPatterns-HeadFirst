using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Ex1.Classes
{
    /// <summary>
    /// Pato de Borracha (Não deve voar)
    /// </summary>
    class RubberDuck : Duck
    {
        public override void Quack()
        {
            Console.WriteLine("Chia (Squeak) ao invés de grasnar");
        }

        public override void Fly()
        {
            //base.Fly(); //  Caso fosse necessário executar o método da classe base (superclasse) antes da execução deste método

            // Substitui p/ fazer nada
        }
    }
}