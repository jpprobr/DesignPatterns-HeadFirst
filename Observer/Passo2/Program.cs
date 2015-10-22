using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passo2
{
    /// <summary>
    /// WeatherStation
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            // 
            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);

            // Simula alterações das medições
            weatherData.SetMeasurements(80, 65, 30.4);
            weatherData.SetMeasurements(82, 70, 29.2);
            weatherData.SetMeasurements(78, 90, 29.2);

            Console.ReadKey();
        }
    }
}