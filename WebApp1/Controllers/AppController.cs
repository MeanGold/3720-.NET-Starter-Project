using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
//using System.Web.Security.FormsAuthentication;
using WebApp1.Data;
using WebApp1.Data.Entities;

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

        [HttpPost]
        //[Authorize]
        public IActionResult Login(string username, string password)
        {
            if (username != null && password != null) {
                int userLogin = _userRepository.ValidateUser(username, password);
                if (userLogin == -1)
                {
                    ViewData["loginErrorMessage"] = "Please enter your username";
                    return View(); 
                } else if (userLogin == -2)
                {
                    ViewData["loginErrorMessage"] = "Invalid password! Please try again!";
                    return View(); 
                } else
                {
                    return RedirectToAction("index", "account", new { userID = userLogin });
                }
            } else
            {
                ViewData["loginErrorMessage"] = "No username or password submitted! Please enter a username and password";
                return View(); 
            }
        }

        // public IActionResult Events()
        // {
        //     return View();
        // }
    }
}