using Microsoft.AspNetCore.Mvc;
using WebApp1.Data;

namespace WebApplication1.Controllers
{
    public class AppController : Controller
    {
        private readonly IUserRepository _userRepository;
        public AppController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IActionResult ShowUsers()
        {
            var results = from u in _userRepository.GetAllUsers()
                          select u;

            return View(results.ToList());
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CustomerService()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        // public IActionResult Events()
        // {
        //     return View();
        // }
    }
}