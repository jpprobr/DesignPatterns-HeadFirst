using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Ex3
{
    public class Duck
    {
        public IFlyBehavior flyBehavior;
        public IQuackBehavior quackBehavior;


        public void PerformFly()
        {
            // Delega ação para classe de comportamento
            flyBehavior.Fly();
        }

        public void PerformQuack()
        {
            // Delega ação para classe de comportamento
            quackBehavior.MakeASound();
        }


        public void Swim()
        {
            System.Console.WriteLine("Todos os patos flutuam, exceto os de madeira!");
        }

        public void Display()
        {
            System.Console.WriteLine("O pato é exibido");
        }

        

        // Métodos de configuração p/ definir o tipo de comportamento dos patos na subclasse ao invés de criar instancias no construtor
        // Pode-se chamar estes métodos sempre que quiser alterar o comportamento de um pato durante o vôo por exemplo.

        public void SetFlyBehavior(IFlyBehavior fb)
        {
            this.flyBehavior = fb;
        }

        public void SetQuackBehavior(IQuackBehavior qb)
        {
            this.quackBehavior = qb;
        }
    }
}