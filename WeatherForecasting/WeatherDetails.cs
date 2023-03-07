using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WeatherForecasting
{
    public class WeatherDetail: Place
    {
        public int Temperature { get; set;}
        public int WindSpeed { get; set; }
        public int Humidity { get; set; }

        public enum Status
        {
            Sunny, Windy, Rainy, Cloudy, Stormy
        }
        public WeatherDetail(int temperature, int windSpeed, int humidity)
        {
            this.Temperature = temperature;
            this.WindSpeed = windSpeed;
            this.Humidity = humidity;

            if (temperature >= 30 && windSpeed <= 12 && humidity <= 5)
            {
                Console.WriteLine(Status.Sunny);
                Console.WriteLine("\nNote: Have fun outside! It is sunny!");
            }
            else if (temperature >= 0 && windSpeed >= 20 && humidity <= 5)
            {
                Console.WriteLine(Status.Windy);
                Console.WriteLine("\nNote: Grab some kite for we will have a heavy blow of wind.");
            }
            else if (temperature <= 20 && windSpeed <= 12 && humidity <= 10)
            {
                Console.WriteLine(Status.Rainy);
                Console.WriteLine("\nNote: Please bring an umbrella, it will rain.");
            }
            else if (temperature <= 20 && windSpeed <= 10 && humidity <= 7)
            {
                Console.WriteLine(Status.Cloudy);
                Console.WriteLine("\nNote: Umbrella is important just to make sure.");
            }
            else if (temperature <= 20 && windSpeed >= 30 && humidity >= 15)
            {
                Console.WriteLine(Status.Stormy);
                Console.WriteLine("\nNote: There will be a storm, just stay home or evacuate.");
            }
            else
            {
                Console.WriteLine("\nThere must have something wrong with the program.");
            }

        }

    }
}
