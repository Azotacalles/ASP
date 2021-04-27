using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsManager
{
    public class WeatherList
    {
        private List<WeatherForecast> list = new List<WeatherForecast>();

        public List<WeatherForecast> List { get => list; set => list = value; }
    }
}
