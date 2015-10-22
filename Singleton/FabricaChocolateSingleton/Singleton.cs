using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaChocolateSingleton
{
    public class Singleton
    {
        private static Singleton _uniqueInstance;

        //public static Singleton UniqueInstance
        //{
        //    get 
        //    {
        //        if (_uniqueInstance == null)
        //            _uniqueInstance = new Singleton();  
                    
        //        return _uniqueInstance; 
        //    }
        //}

        private Singleton() { }

        public static Singleton GetInstance()
        {
            if (_uniqueInstance == null)
            {
                Console.WriteLine("\n Instancia criada!");
                _uniqueInstance = new Singleton();
            }

            return _uniqueInstance;
        }
    }
}

