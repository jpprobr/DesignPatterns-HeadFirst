using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passo2
{
    /// <summary>
    /// Classe Abstrata de Bebida
    /// </summary>
    public abstract class Beverage
    {
        string description = "Bebida desconhecida";


        public virtual string GetDescription()
        {
            return description;
        }

        public abstract double Cost(); // Método abstrato (p/ ser implementado nas subclasses)
    }
}