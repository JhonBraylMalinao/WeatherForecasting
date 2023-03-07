using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecasting
{
    public class Cloud: WeatherDetail
    {
        int humidity;
        string cloudType;

        public Cloud(int humidity, string cloudtype) 
        {
            this.Humidity = humidity;
            this.cloudType = cloudtype;
        }
    }
}
