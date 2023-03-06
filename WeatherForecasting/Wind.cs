using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecasting
{
    public class Wind
    {
        int windSpeed;
        string windDirection;

        public Wind(int windSpeed, string windDirection)
        {
            this.windSpeed = windSpeed;
            this.windDirection = windDirection;
        }

        public override string ToString()
        {
            return base.ToString() + "\nWindSpeed: " + windSpeed.ToString() + "\nWind Direction: " + windDirection.ToString();
        }

    }
}
