using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringSystem
{
    /// <summary>
    /// A singleton class tasked with gathering weather information and alerting observers.
    /// </summary>
    public sealed class WeatherData
    {
        private static readonly WeatherData instance = new WeatherData();
        private List<IDisplay> observers;
        private Random random;

        // Single instance
        public static WeatherData Instance
        {
            get { return instance; }
        }

        private WeatherData()
        {
            observers = new List<IDisplay>();
            random = new Random();
        }

        // Attach an observer
        public void Attach(IDisplay observer)
        {
            observers.Add(observer);
        }

        // Detach an observer
        public void Detach(IDisplay observer)
        {
            observers.Remove(observer);
        }

        // Notify all observers when weather data changes
        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Display();
            }
        }

        // Simulate weather data change (for demonstration)
        public void MeasurementsChanged()
        {
            // Generate random weather data
            int temperature = random.Next(0, 40);
            int humidity = random.Next(0, 100);
            int pressure = random.Next(980, 1050);

            // Update weather data
            SetMeasurements(temperature, humidity, pressure);
        }

        // Set weather data
        public void SetMeasurements(int temperature, int humidity, int pressure)
        {
            // Set weather data here
            // For simplicity, just printing the data
            Console.WriteLine($"Weather Data Updated: Temperature = {temperature}, Humidity = {humidity}, Pressure = {pressure}");
            // Notify observers
            NotifyObservers();
        }
    }
}
