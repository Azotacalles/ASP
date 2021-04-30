using Microsoft.AspNetCore.Mvc;
using System;

namespace MetricsManager.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherForecastController : ControllerBase
    {
        private readonly WeatherList weatherList;

        public WeatherForecastController(WeatherList weatherList)
        {
            this.weatherList = weatherList;
        }

        [HttpPost("create")]
        public IActionResult Create([FromQuery] DateTime date, [FromQuery] int temperature)
        {
            WeatherForecast weather = new WeatherForecast(date, temperature);
            weatherList.List.Add(weather);
            return Ok();
        }

        [HttpGet("read")]
        public IActionResult Read([FromQuery] DateTime dateBegin, [FromQuery] DateTime dateEnd)
        {
            WeatherList weather = new WeatherList();
            for (int i = 0; i < weatherList.List.Count; i++)
            {
                int result1 = DateTime.Compare(weatherList.List[i].Date, dateBegin);
                int result2 = DateTime.Compare(weatherList.List[i].Date, dateEnd);
                if(result1 >= 0 && result2 < 1)
                {
                    weather.List.Add(weatherList.List[i]);
                }
            }
            return Ok(weather.List);
        }

        [HttpPut("update")]
        public IActionResult Update([FromQuery] DateTime date, [FromQuery] int temperature)
        {
            foreach (var item in weatherList.List)
            {
                if (item.Date == date) item.Temperature = temperature;
            }
            return Ok();
        }

        [HttpDelete("delete")]
        public IActionResult Delete([FromQuery] DateTime dateBegin, [FromQuery] DateTime dateEnd)
        {
            for (int i = 0; i < weatherList.List.Count; i++)
            {
                int result1 = DateTime.Compare(weatherList.List[i].Date, dateBegin);
                int result2 = DateTime.Compare(weatherList.List[i].Date, dateEnd);
                if (result1 >= 0 && result2 < 1)
                {
                    weatherList.List.RemoveAt(i);
                }
                i--;
            }

            return Ok();
        }
    }
}
