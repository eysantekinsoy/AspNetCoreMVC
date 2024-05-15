using Microsoft.AspNetCore.Mvc;

namespace Example01.WebApplication1.Controllers
{
    public class OperationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string GetPerson(int test,int id)
        {
            islem(5, "değer", true);
            islem(z: true, x: 5, y: "değer");
            
            return "Sonuç: " + test;

        }

        public void islem(int x,string y,bool z)
        {

        }
    }
}
