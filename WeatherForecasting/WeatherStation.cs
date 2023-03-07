using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecasting
{
    public class WeatherStation : Place
    {
        public string StationId { get; private set; }
        public string TemperatureUnit { get; set; }

        public WeatherStation(string Name, string Region, int Latitude, int Longtitude, string StationId, string TemperatureUnit) : base(Name, Region, Latitude, Longtitude)
        {
            this.StationId = StationId;
            this.TemperatureUnit = TemperatureUnit;
        }

        public override string ToString()
        {
            return base.ToString() + "\nStation ID: " + StationId.ToString() + "\nTemperature Unit: " + TemperatureUnit.ToString();
        }
    }
}
