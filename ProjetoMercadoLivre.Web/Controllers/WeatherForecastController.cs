using Microsoft.EntityFrameworkCore;
using ProjetoMercadoLivre.Lib.Data;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoMercadoLivre.Web.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly MercadoLivreContext _context; 

    public WeatherForecastController(ILogger<WeatherForecastController> logger, MercadoLivreContext context)
    {
        _logger = logger;
        _context = context;
    }
    
    [HttpGet("Primeiro/(id)")]
    public IActionResult GetTeste(int id)
    {
        var usuarios = _context.Usuarios.Update;
        return Ok(usuarios);
    }

    [HttpGet("Segundo/(id)")]
    public IActionResult GetTeste2(int id)
    {
        var produtos = _context.Produtos.Update;
        return Ok(produtos);
    }

    [HttpGet("Terceiro/(id)")]
    public IActionResult GetTeste3(int id)
    {
        var pedidos = _context.Pedidos.Update;
        return Ok(pedidos);
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
}
