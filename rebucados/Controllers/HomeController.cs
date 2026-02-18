using Microsoft.AspNetCore.Mvc;

namespace Login23.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
