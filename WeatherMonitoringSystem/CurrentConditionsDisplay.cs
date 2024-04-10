using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringSystem
{
    /// <summary>
    /// This observer implementation is dedicated to showing the current weather conditions. Additionally, it acts as a decorator to enrich the displayed data with extra details.
    /// </summary>
    public class CurrentConditionsDisplay : IDisplay
    {
        private int humidity;
        private int temperature;
        private WeatherData weatherData;

        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.Attach(this); // Register as an observer
        }

        // Change weather conditions
        public void Update(int temperature, int humidity)
        {
            this.humidity = humidity;
            this.temperature = temperature;
            Display(); // Update display
        }

        // Show current weather conditions
        public void Display()
        {
            Console.WriteLine($"Current Conditions: {temperature}°C and {humidity}% humidity");
        }
    }
}
