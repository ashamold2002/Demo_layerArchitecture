using Microsoft.AspNetCore.Mvc;

namespace Demo.API.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IWeatherservice _weatherservice;
    public WeatherForecastController(ILogger<WeatherForecastController> logger,IWeatherservice weatherservice)
    {
        _logger = logger;
        _weatherservice = weatherservice;
    }

    [HttpGet]
    public IEnumerable<WeatherForecast> Get()
    {
        var result = _weatherservice.Get();
        return result;
    }
}
