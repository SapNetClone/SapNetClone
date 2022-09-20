using System.Diagnostics;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using SapNetClone.Application.Abstract.Repositories.UsersRepository;
using SapNetClone.Application.Features.User.GetAllUser;
using SapNetClone.Application.ViewModels.Users;
using SapNetClone.Web.Models;

namespace SapNetClone.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IUserReadRepository _userReadRepository;
    readonly IMediator _mediator;


    public HomeController(ILogger<HomeController> logger, IUserReadRepository userReadRepository, IMediator mediator)
    {
        _logger = logger;
        _userReadRepository = userReadRepository;
        _mediator = mediator;
    }
    [HttpGet]
    public async Task<IActionResult> Index(GetAllUserQueryRequest request)
    {
        var response = await _mediator.Send(request);  
        return View(response.UserVMs.ToList());
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
