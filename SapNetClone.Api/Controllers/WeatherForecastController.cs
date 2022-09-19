using Microsoft.AspNetCore.Mvc;
using SapNetClone.Application.Abstract.Repositories.UsersRepository;

namespace SapNetClone.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };


    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IUserReadRepository _userReadRepository;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, IUserReadRepository userReadRepository)
    {
        _logger = logger;
        _userReadRepository = userReadRepository;
    }


    

    [HttpGet]
    public ActionResult Get()
    {
        var data = _userReadRepository.GetAll().ToList();
        return Ok(data);
    }
}