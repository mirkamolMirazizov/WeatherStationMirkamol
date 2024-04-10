// ForecastDisplay.cs
using System;

namespace WeatherMonitoringSystem
{
    /// <summary>
    /// A specific observer designed to present a weather prediction.
    /// </summary>

    public class ForecastDisplay : IDisplay
    {
        private WeatherData weatherData;
        public ForecastDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.Attach(this); // Register as an observer
        }

        // Refresh the weather prediction
        public void Update(int temperature, int humidity)
        {
            // Adjust the forecast according to current weather conditions.
            // To keep it straightforward, if the temperature is above 25°C, predict sunshine; if not, expect rain.
            string forecast = temperature > 25 ? "Sunny" : "Rainy";

            Display(forecast); // Update display
        }

        // Refresh the weather prediction
        public void Display()
        {
            // For the ForecastDisplay, no immediate forecast is shown. 
            // It awaits the Update method to deliver the forecast information.
            // Hence, this method can remain unimplemented.
        }

        // Enhanced Display method to incorporate forecast information
        public void Display(string forecast)
        {
            Console.WriteLine($"Weather Forecast: {forecast}");
        }
    }
}
