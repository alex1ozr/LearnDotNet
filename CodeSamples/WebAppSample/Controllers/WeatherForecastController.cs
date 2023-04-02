using LearnDotNet.WebAppSample.Services;
using Microsoft.AspNetCore.Mvc;
using WebAppSample;

namespace LearnDotNet.WebAppSample.Controllers;

[ApiController]
[Route("api/v1/weather-forecasts/")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly ISampleService _sampleService;

    public WeatherForecastController(
        ILogger<WeatherForecastController> logger,
        ISampleService sampleService)
    {
        _logger = logger;
        _sampleService = sampleService;
    }
    
    [HttpGet("cities/get-by-ids", Name = "GetWeatherByCityIds")]
    public ActionResult<IEnumerable<WeatherForecast>> Get([FromQuery]IEnumerable<int>? ids = null)
    {
        Console.WriteLine(_sampleService.GetValue);

        var result = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        return Accepted(result);
    }

    [HttpGet("cities/dates", Name = "GetWeatherByDate")]
    public IEnumerable<WeatherForecast> GetByDate(DateTime from, DateTime to)
    {
        Console.WriteLine(_sampleService.GetValue);
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
    }
    
    [HttpGet("cities/{cityId}", Name = "GetWeatherByCityId")]
    public IEnumerable<WeatherForecast> Get(int cityId)
    {
        Console.WriteLine(_sampleService.GetValue);
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
    }
    
    [HttpPost("cities/{id}", Name = "SaveWeatherForecast")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<int>))]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    public IActionResult SaveData([FromRoute] int id, [FromBody] MyClass data)
    {
        if (id < 100)
        {
            return BadRequest("blahblah");
        }
        Console.WriteLine(_sampleService.GetValue);
        // do..

        return Ok(new[] { id });
    }
    
    [HttpDelete("cities/{id}", Name = "DeleteWeatherForecast")]
    public void Delete(Guid id)
    {
        Console.WriteLine(_sampleService.GetValue);
        // do..
    }
    
    [HttpPost("cities/{id}/do-something", Name = "DoSomething")]
    public void DoSomething(Guid id)
    {
        Console.WriteLine(_sampleService.GetValue);
        // do..
    }
    
    public class MyClass
    {
        public string? Value { get; set; }
        
        public int IntValue { get; set; }
    }
}