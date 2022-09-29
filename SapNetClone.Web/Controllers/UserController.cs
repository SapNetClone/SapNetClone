using Microsoft.AspNetCore.Mvc;
using SapNetClone.Application.Abstract.Repositories.UsersRepository;
using SapNetClone.Application.ViewModels.Users;

namespace SapNetClone.Web.Controllers
{
    public class UserController : Controller
    {
        readonly IUserReadRepository _userReadRepository;
        readonly IUserWriteRepository _userWriteRepository;
        public UserController(IUserReadRepository userReadRepository,IUserWriteRepository userWriteRepository)
        {
            this._userReadRepository = userReadRepository;
            this._userWriteRepository = userWriteRepository;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var data = _userReadRepository.GetAll().Select(user => new ListUserVM()
            {
                Id = user.Id,
                Name = user.Name,
                SocialSecurityCode = user.SocialSecurityCode,
                CreatedDate = user.CreatedDate,
                Email = user.Email,
                TelephoneNumber = user.TelephoneNumber,
            }).ToList();
           
            return View(data);
        }
      
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _userWriteRepository.Remove(id);
            if (result)
            {
                return Ok("Success");
            }
            //await userWriteRepository.SaveAsync();
            return Ok("Error");
        }

        public IActionResult Detail()
        {
            throw new NotImplementedException();
        }

        public IActionResult Edit()
        {
            throw new NotImplementedException();
        }
    }
}
