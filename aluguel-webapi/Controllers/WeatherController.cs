using Microsoft.AspNetCore.Mvc;
using aluguel_webapi.Entities;

namespace aluguel_webapi.Controllers;

[Controller]
[Route("/weather")]
public class WeatherController : ControllerBase
{
    
    private string[] summaries = 
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    [HttpGet]
    public IActionResult GetWeatherForecast()
    {
        var forecast =  Enumerable.Range(1, 5).Select(index => new WeatherForecast(
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();

        return Ok(forecast);
    }

}