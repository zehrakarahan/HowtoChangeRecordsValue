using Microsoft.AspNetCore.Mvc;
using Records;
using System;

namespace dsa.Controllers
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
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
        [HttpGet("RecordNew")]
        public IActionResult Records(string firstName, string lastName)
        {
            var person1 = new Person("John", "Doe");
            var person2 = person1 with { LastName = "Smith" };


           
            var person = new Person(firstName, lastName);

            return Ok(person2);
        }


        [HttpGet("RecordChange")]
        public IActionResult Getir(Person person)
        {
            return Ok(person);
        }
    }
}
