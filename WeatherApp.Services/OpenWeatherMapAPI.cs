using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Entities;

namespace WeatherApp.Services
{
    public class OpenWeatherMapAPI
    {
        private WeatherData GetWeather(string city)
        {
            using (var client = new WebClient())
            {
                string json = client.DownloadString($"http://api.openweathermap.org/data/2.5/weather?appid=32f981a8fd9edcdd55e07c54aafc263d&q={city}&units=metric");
                WeatherData weather = JsonConvert.DeserializeObject<WeatherData>(json);
                return weather;
            }
        }

        public double GetCurrentTemperature(string city)
        {
            WeatherData weather = GetWeather(city);
            double temp = weather.Main.Temp;
            return temp;
        }
    }
}
