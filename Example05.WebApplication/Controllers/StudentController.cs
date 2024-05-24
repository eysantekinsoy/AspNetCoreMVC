using Example05.WebApplication.Models;
using Example05.WebApplication.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Example05.WebApplication.Controllers
{
    public class StudentController : Controller
    {
        private const string _pageTitle = "Student";
        private MenuService _menuService;

        public StudentController()
        {
            _menuService = new MenuService();
        }

        // GET: StudentController
        public ActionResult Index()
        {
            ViewBag.Menus = _menuService.GetMenus();
            ViewBag.Title = $"{_pageTitle} Index";
            ViewData["baslik"] = "Öğrenciler";
            //ViewData["Title"] = "ÖĞRENCİLER";

            Student student= new Student();
            return View(student);
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            ViewBag.Menus = _menuService.GetMenus();
            ViewBag.Title = $"{_pageTitle} Index";

            return View();
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            ViewBag.Menus = _menuService.GetMenus();
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ViewBag.Menus = _menuService.GetMenus();
                return View();
            }
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.Menus = _menuService.GetMenus();
            return View();
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ViewBag.Menus = _menuService.GetMenus();
                return View();
            }
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            ViewBag.Menus = _menuService.GetMenus();
            return View();
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ViewBag.Menus = _menuService.GetMenus();
                return View();
            }
        }
    }
}
