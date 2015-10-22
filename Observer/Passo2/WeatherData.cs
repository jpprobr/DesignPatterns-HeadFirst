using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passo2
{
    public class WeatherData : ISubject
    {
        /// <summary>
        /// Coleção para conter os Observadores
        /// </summary>
        private List<IObserver> _observers;

        private double _temperature;
        private double _humidity;
        private double _pressure;

        /// <summary>
        /// Obtem dados de Temperatura
        /// </summary>
        public double Temperature
        {
            get { return _temperature; }
        }

        /// <summary>
        /// Obtem dados de Humidade
        /// </summary>
        public double Humidity
        {
            get { return _humidity; }
        }

        /// <summary>
        /// Obtem dados de Pressão Barométrica
        /// </summary>
        public double Pressure
        {
            get { return _pressure; }
            set { _pressure = value; }
        }


        /// <summary>
        /// Construtor 
        /// </summary>
        public WeatherData()
        {
            this._observers = new List<IObserver>();
        }


        public void RegisterObserver(IObserver o)
        {
            this._observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            //// Obtem indice do observador
            //int i = this._observers.IndexOf(o);

            //// Remove observador da coleção
            //if (i >= 0)
            //    this._observers.RemoveAt(i);

            this._observers.Remove(o);
        }

        public void NotifyObservers()
        {           
            for (int i = 0; i < this._observers.Count; i++) // No java use o .size()
            {
                // Obtem o Observador atual
                IObserver observer = this._observers[i];

                // Executa Update do Observador
                observer.Update(this._temperature, this._humidity, this._pressure);
            }
        }

        /// <summary>
        /// Método que será chamado quando as medidas forem atualizadas
        /// </summary>
        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        /// <summary>
        /// Método de TESTE p/ alterar valores das medidas (Simula uma Estação Meteorológica)
        /// </summary>
        /// <param name="temperature"></param>
        /// <param name="humidity"></param>
        /// <param name="pressure"></param>
        public void SetMeasurements(double temperature, double humidity, double pressure)
        {
            // Altera valores das medidas
            this._temperature = temperature;
            this._humidity = humidity;
            this._pressure = pressure;

            // Chama método  
            MeasurementsChanged();
        }
    }
}