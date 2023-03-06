using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecasting
{
    public class Place 
    {
        public string Name { get; private set; }
        public string Region { get; private set; }
        public int Latitude { get; private set; }
        public int Longtitude { get; private set; }

        public Place(string Name, string Region, int Latitude, int Longtitude)
        {
            this.Name = Name;
            this.Region = Region;
            this.Latitude = Latitude;
            this.Longtitude = Longtitude;
        }

        public override string ToString()
        {
            return base.ToString() + "\nCity: " + Name.ToString() + "\nRegion: " + Region.ToString() + "\nLatitude: " + Latitude.ToString() + "\nLongtitude: " + Longtitude.ToString();
        }
    }
}
