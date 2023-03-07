using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecasting
{
    public class Wind : WeatherDetail
    {
        int WindSpeed;
        string windDirection;
      
       public Wind(int WindSpeed, string windDirection)
        {
            this.WindSpeed = WindSpeed;
            this.windDirection = windDirection;
        }

        public static void showWindProperties(int WindSpeed, string WindDirection)
        {
            WindSpeed = WindSpeed;
            WindDirection = WindDirection;
 
        }

        public override string ToString()
        {
            return base.ToString() + "\nWindSpeed: " +WindSpeed.ToString() + "\nWind Direction: " + windDirection.ToString();
        }

    }
}
