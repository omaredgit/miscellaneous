using Microsoft.AspNetCore.Mvc;
using OopConcepts.Encapsulation;
namespace miscellaneous.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<string> Get(int increaseCountNumber)
        {
            var developerName = new Developer("Omar", "Eduardo", "Carvajal", "Guerra");
            var Result = new List<string>();

            developerName.IncreaseTheCount = increaseCountNumber;
            Result.Add(developerName.FirstName);
            Result.Add(developerName.TwoFirstNames);
            Result.Add(developerName.ThreeFirstNames);
            Result.Add(developerName.FourFirstNames);
            return Result;
  
        }
    }
}