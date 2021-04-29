using System;
using System.Collections.Generic;

namespace MetricsManager
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }
        public int Temperature { get; set; }

        public WeatherForecast(DateTime date, int temperature)
        {
            Date = date;
            Temperature = temperature;
        }
    }
}
