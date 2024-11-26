using Microsoft.AspNetCore.Mvc;
using WebApp1.Data.Entities;
using WebApp1.Data;

namespace WebApplication1.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Profile()
        {
            return View();
        }
        private readonly IUserRepository _userRepository;
        public AccountController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        [HttpPost]
        [ActionName("updateUser")]
        public IActionResult Index(User user)
        {

            _userRepository.UpdateUser(user);
            _userRepository.SaveAll();

            return View();
        }
    }
}