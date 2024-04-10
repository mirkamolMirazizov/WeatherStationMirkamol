// Program.cs (Console Application)
using System;

namespace WeatherMonitoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create WeatherData singleton instance
            WeatherData weatherData = WeatherData.Instance;

            // Create different displays using the factory
            CurrentConditionsDisplay currentConditionsDisplay = WeatherStation.CreateCurrentConditionsDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = WeatherStation.CreateStatisticsDisplay(weatherData);
            ForecastDisplay forecastDisplay = WeatherStation.CreateForecastDisplay(weatherData);

            // Simulate weather data changes
            weatherData.MeasurementsChanged();
        }
    }
}
