using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passo2
{
    public class ForecastDisplay : IObserver, IDisplayElement
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
        /// Construtor
        /// </summary>
        /// <param name="weatherData"></param>
        public ForecastDisplay(ISubject weatherData)
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
            this._pressure = pressure;

            // Executa método de Exibir
            Display();
        }

        public void Display()
        {
            // Aqui vai a implementação da exibição de Previsão do Tempo
            Console.WriteLine("Previsão do tempo...");
            Console.WriteLine();
        }
    }
}
