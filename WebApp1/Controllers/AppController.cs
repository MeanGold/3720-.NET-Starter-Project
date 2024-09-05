using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}