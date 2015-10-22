using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passo2
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        // Atributos locais
        private double _temperature;
        private double _humidity;
        private double _pressure;

        /// <summary>
        /// Atributo de referência ao Sujeito
        /// </summary>
        private ISubject _weatherData;

        // Variáveis p/ cálculo
        private double _maxTemp = 0.0f;
        private double _minTemp = 200;
        private double _temperatureSum = 0.0f;
        private int _numReadings = 0;


        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="weatherData"></param>
        public StatisticsDisplay(ISubject weatherData)
        {
            // Recebe o objeto WeatherData passado por parametro
            this._weatherData = weatherData;

            // Registra esta Exibição como um observador
            weatherData.RegisterObserver(this);
        }

        public void Update(double temp, double humidity, double pressure)
        {
            _temperatureSum += temp;
            _numReadings++;

            if (temp > this._maxTemp)
            {
                this._maxTemp = temp;
            }

            if (temp < this._minTemp)
            {
                this._minTemp = temp;
            }

            // Executa método de Exibir
            Display();
        }

        public void Display()
        {
            // Aqui vai a implementação da exibição de Estatísticas
            Console.WriteLine("Estatísticas:");
            //Console.WriteLine("Temperatura: " + this._temperature + " graus Celsius ");
            //Console.WriteLine("Umidade:  " + this._humidity + "%");
            //Console.WriteLine("Pressão Atmosférica:  " + this._pressure);
            Console.WriteLine("Avg/Max/Min temperature = " + RoundFloatToString(this._temperatureSum / this._numReadings) + "ºC /" + this._maxTemp + "ºC /" + this._minTemp + "ºC");
            Console.WriteLine();
        }



        public static string RoundFloatToString(double floatToRound)
        {
            System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("en-US");
            cultureInfo.NumberFormat.CurrencyDecimalDigits = 2;
            cultureInfo.NumberFormat.CurrencyDecimalSeparator = ".";
            return floatToRound.ToString("F", cultureInfo);
        }
    }
}