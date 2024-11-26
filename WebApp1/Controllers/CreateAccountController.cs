using Microsoft.AspNetCore.Mvc;
using WebApp1.Data;
using WebApp1.Data.Entities;


namespace WebApplication1.Controllers
{
    public class CreateAccountController : Controller
    {
        private readonly IUserRepository _userRepository;
        public CreateAccountController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        [HttpPost]
        [ActionName("newUser")]
        public IActionResult newUser(User user)
        {
            
            _userRepository.CreateUser(user);
            _userRepository.SaveAll();
            
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}