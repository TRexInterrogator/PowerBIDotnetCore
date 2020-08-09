using Microsoft.AspNetCore.Mvc;
using src.Authentication;

namespace src.Controllers
{

    [Token]
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase {
        

        /// <summary>
        /// Endpoint for requesting weather forecast data
        /// </summary>
        /// <returns>List of WeatherForecast datamodels</returns>
        [HttpGet("data")]
        [Produces("application/json")]
        public IActionResult GetWeatherForecastData([FromQuery(Name = "month")] int month, [FromQuery(Name = "year")] int year) {

            return this.Ok(WeatherForecast.RequestMonthAsync(month, year));
        }
    }
}
