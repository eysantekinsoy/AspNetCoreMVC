using Microsoft.AspNetCore.Mvc;

namespace Example01.WebApplication1.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
