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
        //private StudentService _studentService;
        public StudentController()
        {
            _menuService = new MenuService();
            //_studentService=new StudentService();
        }

        // GET: StudentController
        public ActionResult Index()
        {
            ViewBag.Menus = _menuService.GetMenus();
            ViewBag.Title = $"{_pageTitle} Index";
            ViewData["baslik"] = "Öğrenciler";

            //ViewBag.KayitDeneme = ViewBag.Deneme?? "ViewBag.Deneme gelemedi..";
            //ViewData["KayitEkBilgi"] = ViewData["EkBilgi"] ?? "ViewData.['EkBilgi'] gelemedi..";

            //string tempData = "TempData['KayitDurumu'] henüz gönderilmedi";

            //if (TempData["KayitDurumu"] != null)
            //{
            //    tempData = TempData["KayitDurumu"].ToString();
            //}

            //ViewBag.KayitTempData=tempData;

            //ViewData["Title"] = "ÖĞRENCİLER";

            List<Student> students = StudentService.Students();

            if (TempData.Any())
            {
                if (TempData["CreateStatus"] != null)
                {
                    if ((bool)TempData["CreateStatus"])
                    {
                        ViewBag.CreateStatus = true;

                    }
                    else
                    {

                        ViewBag.CreateStatus = false;
                    }

                    ViewBag.CreateMessage = TempData["CreateMessage"];

                }

            }
            return View(students);
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
            ViewData["baslik"] = "Yeni Öğrenci";

            Student student = new Student();
            return View(student);
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //public ActionResult Create(string name, string surname, string email, string birthDate, string gender, string studentStatus)
        public ActionResult Create(Student student)
        {
            try
            {
                //ViewBag.Deneme = "view bag geldi mi";
                //ViewData["EkBilgi"] = "view data geldi mi";

                //TempData["KayitDurumu"] = "Kayıt başarılı oldu.";

                //string name = collection["name"];
                //string surname = collection["Surname"];
                //string email = collection["Email"];
                //string birthDate = collection["BirtDate"];
                //string gender = collection["Gender"];
                //string status = collection["StudentStatus"];

                string name = student.Name;
                string surname = student.Surname;
                string email = student.Email;
                DateOnly birthDate = student.BirthDate;
                Gender gender = student.Gender;
                StudentStatus status = student.StudentStatus;

                StudentService.AddStudent(student);

                TempData["CreateStatus"] = true;
                TempData["CreateMessage"] = $"{name} {surname} sistemimize başarıyla kayıt oldu.";


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
