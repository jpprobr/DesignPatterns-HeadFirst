using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passo1
{
    public class WeatherData
    {
        /// <summary>
        /// Obtem dados de Temperatura
        /// </summary>
        public double GetTemperature()
        {
            return 0;
        }

        /// <summary>
        /// Obtem dados de Humidade
        /// </summary>
        public double GetHumidity()
        {
            return 0;
        }

        /// <summary>
        /// Obtem dados de Pressão Barométrica
        /// </summary>
        public double GetPressure()
        {
            return 0;
        }


        public void MeasurementsChanged()
        {            
            // Obtem dados das medições mais recentes através os métodos de obtenção (já implementados)
            double temperature = GetTemperature();
            double humidity = GetHumidity();
            double pressure = GetPressure();
            
            // Atualiza as Exibições passando as medições mais recentes
            CurrentConditionsDisplay.Update(temperature, humidity, pressure);
            StatisticsDisplay.Update(temperature, humidity, pressure);
            ForecastDisplay.Update(temperature, humidity, pressure);


            // Outros métodos do WeatherData aqui...
            
        }
    }










    public class CurrentConditionsDisplay
    {
        public static void Update(double temp, double humid, double pressure) { }
    }

    public class StatisticsDisplay
    {
        public static void Update(double temp, double humid, double pressure) { }
    }

    public class ForecastDisplay
    {
        public static void Update(double temp, double humid, double pressure) { }
    }      
}
