using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class homeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CustomerService()
        {
            return View();
        }
    }

    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}