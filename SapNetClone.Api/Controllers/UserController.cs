using Microsoft.AspNetCore.Mvc;
using SapNetClone.Application.Abstract.Repositories.UsersRepository;
using SapNetClone.Application.ViewModels.Users;
using SapNetClone.Entities.Classes.UsersClasses;

namespace SapNetClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        readonly IUserReadRepository _userReadRepository;
        readonly IUserWriteRepository _userWriteRepository;

        public UserController(IUserReadRepository userReadRepository, IUserWriteRepository userWriteRepository)
        {
            _userReadRepository = userReadRepository;
            _userWriteRepository = userWriteRepository;
        }
        [HttpGet]
        public ActionResult<List<User>> Get()
        {
            var data = _userReadRepository.GetAll().ToList();
            return data;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetByIdAsync(int id)
        {
            return await _userReadRepository.GetByIdAsync(id);
        }
        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateUserVM createUserVM)
        {
            User userToAdd = new()
            {
                Name = createUserVM.Name,
                Password = createUserVM.Password,
                CreatedDate = DateTime.Now,
                Active = true
            };
            await _userWriteRepository.AddAsync(userToAdd);
            var result = await _userWriteRepository.SaveAsync();
           
            return Ok(result);           
        }
    }
}
