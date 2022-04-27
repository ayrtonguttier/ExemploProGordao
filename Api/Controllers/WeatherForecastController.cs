using Dominio;
using Dominio.Modelo;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly DominioPessoa _dominio;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, DominioPessoa dominio)
    {
        _logger = logger;
        _dominio = dominio;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
    }

    
    
    
    [HttpPost]
    public IActionResult CadastrarPessoa(Pessoa pessoa)
    {
        _dominio.CadastrarPessoa(pessoa);
        return Ok();
    }
}