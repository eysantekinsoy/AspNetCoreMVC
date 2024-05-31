using Example07.WebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text;

namespace Example07.WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //public JsonResult Index()
        //{
        //    ErrorViewModel errorViewModel = new ErrorViewModel();
        //    errorViewModel.RequestId=Guid.NewGuid().ToString();

        //    return Json(errorViewModel);

        //}

        public IActionResult Index()
        {
            int sayi = new Random().Next(100, 1001);
            if (sayi % 11 == 9)
            {
                ErrorViewModel errorViewModel = new ErrorViewModel();
                errorViewModel.RequestId = Guid.NewGuid().ToString();

                return Json(errorViewModel);
            }

            else
            {
                return View();

            }

        }

        public ContentResult ContentResult()
        {
            string content = @"
                                <!DOCTYPE html>
                                <html lang=""en"">
                                <head>
                                <link rel=""stylesheet"" href=""/Home/HomeCss""/>
                                <title>Baþlýk</title>
                                </head>
                                <body>
                                <p> HTML Sayfasý olarak oluþturuldu. </p>
                                <button onclick=""ClickMe()"">Týkla</button>
                                <script type=""text/javascript"" src=""/Home/HomeJs""></script>
                                </body>
                                </html>
                                ";
            return Content(content, "text/html", Encoding.UTF8);
        }

        public ContentResult HomeCss()
        {
            string css = @"
                        p{
                            color:blue;
                            font-size:large;
                            font-family:'Franklin Gothic Medium','Arial Narrow', Arial, sans-serif;
                            border: 1px solid black;
                        }";
            return Content(css, "text/css", Encoding.UTF8);
        }

        public ContentResult HomeJs()
        {
            string js = @"
                        function ClickMe(){
                            alert(""Hello world! :)"")}

                        ";
            return Content(js, "text/javascript", Encoding.UTF8);
        }

        public NotFoundResult HttpStatus404()
        {
            return NotFound();
        }        
        public UnauthorizedResult HttpStatus401()
        {
            return Unauthorized();
        }        
        public OkResult HttpStatus200()
        {
            return Ok();
        }
        public ForbidResult HttpStatus403()
        {
            return Forbid();
        }
        public StatusCodeResult HttpStatus410()
        {
            return StatusCode(410);
        }        
        public StatusCodeResult HttpStatus(int id)
        {
            return StatusCode(id);
        }

        public PartialViewResult SubMenu()
        {
            return PartialView("_SubMenu");
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
