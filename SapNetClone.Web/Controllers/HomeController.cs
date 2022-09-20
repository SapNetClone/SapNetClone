using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SapNetClone.Application.Abstract.Repositories.UsersRepository;
using SapNetClone.Web.Models;

namespace SapNetClone.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    
    private readonly IUserReadRepository _userReadRepository;

    
    public HomeController(ILogger<HomeController> logger, IUserReadRepository userReadRepository)
    {
        _logger = logger;
        _userReadRepository = userReadRepository;
    }
[HttpGet]
    public IActionResult Index()
    {
        var data = _userReadRepository.GetAll().ToList();
        return Ok(data);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}