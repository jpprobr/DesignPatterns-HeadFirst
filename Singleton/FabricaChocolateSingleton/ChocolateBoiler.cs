using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaChocolateSingleton
{
    /// <summary>
    /// Classe controladora da Caldeira de chocolate
    /// </summary>
    public class ChocolateBoiler
    {
        private Boolean _empty;
        private Boolean _boiled;

        // Variável estática da Classe
        private static ChocolateBoiler _uniqueInstance;


        public static int QtdeInstancias = 0;

        /// <summary>
        /// Construtor privado da Caldeira
        /// </summary>
        private ChocolateBoiler()
        {
            this._empty = true;
            this._boiled = false;
        }

        /// <summary>
        /// Método estático p/ retornar a instancia da caldeira criada
        /// </summary>
        /// <returns></returns>
        public static ChocolateBoiler GetInstance()
        {
            if (_uniqueInstance == null)
            {                
                _uniqueInstance = new ChocolateBoiler();

                Console.WriteLine("Instancia criada! \n");
                QtdeInstancias++;
            }
                

            return _uniqueInstance;
        }
        
        /// <summary>
        /// Método que verifica se caldeira está vazia ou não
        /// </summary>
        /// <returns>boolean</returns>
        public bool IsEmpty()
        {
            return _empty;
        }

        /// <summary>
        /// Método que verifica se caldeira já ferveu ou não
        /// </summary>
        /// <returns>boolean</returns>
        public bool IsBoiled()
        {
            return _boiled;
        }


        /// <summary>
        /// Enche a caldeira
        /// </summary>
        public void Fill()
        {
            // Verifica se caldeira está vazia p/ poder encher
            if (IsEmpty())
            {
                // Enche a caldeira
                Console.WriteLine("Caldeira preenchida com leite e chocolate! \n");

                // Seta indicadores após encher a caldeira
                this._empty = false;
                this._boiled = false;
            }
        }

        /// <summary>
        /// Drena a caldeira
        /// </summary>
        public void Drain()
        {
            // Verifica se caldeira esta cheia e se já está fervido
            if (!IsEmpty() && IsBoiled())
            {
                // Drena o conteúdo da caldeira
                Console.WriteLine("Caldeira drenada com leite e chocolate fervidos! \n");

                // Seta indicador de vazio
                this._empty = true;
            }
        }

        /// <summary>
        /// Ferve a mistura
        /// </summary>
        public void Boil()
        {
            // Verifica se caldeira está cheia e se ainda não entrou
            if (!IsEmpty() && !IsBoiled())
            {
                // Drena o conteúdo da caldeira
                Console.WriteLine("Conteúdo da caldeira colocado em ebulição! \n");

                // Seta indicador de fervido
                this._boiled = true;
            }
        }
    }
}