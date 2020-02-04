using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Services;

namespace WeatherApp.BIZ
{
    
    public class ClassBIZ
    {
        OpenWeatherMapAPI weatherAPI = new OpenWeatherMapAPI();

        public double GetTemperature(string city)
        {
            double temp = 0;

            try
            {
                temp = weatherAPI.GetCurrentTemperature(city);
            }
            catch (WebException)
            {
                return -404;
            }

            return temp;
        }
    }
}
