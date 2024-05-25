using Example05.WebApplication.Services;
using Microsoft.AspNetCore.Mvc;

namespace Example05.WebApplication.Controllers
{
    public class TeacherController : Controller
    {
        private MenuService _menuService;

        public TeacherController()
        {
            _menuService = new MenuService();
        }
        public IActionResult Index()
        {
            ViewBag.Menus = _menuService.GetMenus();
            return View();
        }

        public IActionResult Create()
        {
            var request = HttpContext.Request;
            var queryString = request.QueryString;
            var query = request.Query;

            if (request.Method == "POST") 
            { 
                var form = request.Form; 
            }

            ViewBag.Menus = _menuService.GetMenus();
            return View();
        }
    }
}
