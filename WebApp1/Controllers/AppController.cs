using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class AppController : Controller
    {
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
    }
}