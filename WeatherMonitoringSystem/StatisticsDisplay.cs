// StatisticsDisplay.cs
using System;

namespace WeatherMonitoringSystem
{
    /// <summary>
    /// Blueprint for all display units.
    /// </summary>
    public class StatisticsDisplay : IDisplay
    {
        private int maxTemperature = int.MinValue;
        private int minTemperature = int.MaxValue;
        private int sumTemperature = 0;
        private int numReadings;
        private WeatherData weatherData;

        public StatisticsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.Attach(this);
        }

        // Change statistics
        public void Update(int temperature, int humidity)
        {
            // Chnage statistics based on temperature
            sumTemperature += temperature;
            numReadings++;
            if (temperature > maxTemperature)
            {
                maxTemperature = temperature;
            }
            if (temperature < minTemperature)
            {
                minTemperature = temperature;
            }

            Display();
        }

        public void Display()
        {
            int averageTemperature = sumTemperature / numReadings;
            Console.WriteLine($"Average Temperature: {averageTemperature}°C");
            Console.WriteLine($"Max Temperature: {maxTemperature}°C");
            Console.WriteLine($"Min Temperature: {minTemperature}°C");
        }
    }
}
