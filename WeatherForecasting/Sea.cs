using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecasting
{
    public class Sea: WeatherDetail
        {
            public double seaLevel { get; set; }
            public int seaCurrent { get; set; }
            public double Salinity { get; set; }
            public Sea(double sealevel, int seacurrent, double salinity)
            {
                seaLevel = sealevel;
                seaCurrent = seacurrent;
                Salinity = salinity;
            }
        }
}
