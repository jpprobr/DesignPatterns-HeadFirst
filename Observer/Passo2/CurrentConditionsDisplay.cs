using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passo2
{
    public class CurrentConditionsDisplay: IObserver, IDisplayElement 
    {
        // Atributos locais
        private double _temperature;
        private double _humidity;
        private double _pressure;
        
        /// <summary>
        /// Atributo de referência ao Sujeito
        /// </summary>
        private ISubject _weatherData;


        /// <summary>
        /// Construtor do elemento de Exibição
        /// </summary>
        /// <param name="weatherData">Objeto WeatherData</param>
        public CurrentConditionsDisplay(ISubject weatherData)
        {
            // Recebe o objeto WeatherData passado por parametro
            this._weatherData = weatherData;

            // Registra esta Exibição como um observador
            weatherData.RegisterObserver(this);
        }


        public void Update(double temp, double humidity, double pressure)
        {
            // Obtem os valores das medidas
            this._temperature = temp;
            this._humidity = humidity;
            
            //this._weatherData = weatherData;
            //this._temperature = weatherData.Temperature;
            //this._humidity = weatherData.Humidity; 

            // Executa método de Exibir
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Condições atuais: " + this._temperature + " graus Celsius e " + this._humidity + "% de umidade.");
            Console.WriteLine();
        }
    }
}