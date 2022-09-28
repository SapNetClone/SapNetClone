using Microsoft.AspNetCore.Mvc;
using SapNetClone.Application.Abstract.Repositories.UsersRepository;

namespace SapNetClone.Web.Controllers
{
    public class UserController : Controller
    {
        readonly IUserReadRepository userReadRepository;
        public UserController(IUserReadRepository userReadRepository)
        {
            this.userReadRepository = userReadRepository;
        }
        public IActionResult Index()
        {
            var data = userReadRepository.GetAll().ToList();
            return View(data);
        }
    }
}
