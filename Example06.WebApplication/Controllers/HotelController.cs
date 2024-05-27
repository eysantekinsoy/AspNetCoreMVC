using Example06.WebApplication.Data;
using Example06.WebApplication.Data.Entities;
using Example06.WebApplication.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Example06.WebApplication.Controllers
{
    public class HotelController : Controller
    {
        private AppDbContext _appDbContext;
        public HotelController()
        {
            _appDbContext = new AppDbContext(); 
        }

        // GET: HotelController
        public ActionResult Index()
        {
            var oteller=_appDbContext.Otels.ToList();

            return View(oteller);
        }

        // GET: HotelController/Details/5
        public ActionResult Details(int id)
        {
            Hotel hotel = new Hotel();
            hotel.Id = id;
            hotel.Name = "Otel adı" + id;
            hotel.Description = "Otel açıklama" + id;
            hotel.Phone = "123456789";
            return View(hotel);
        }

        // GET: HotelController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HotelController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Otel model)
        {
            try
            {
                _appDbContext.Otels.Add(model);
                _appDbContext.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HotelController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HotelController/Edit/5
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
                return View();
            }
        }

        // GET: HotelController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HotelController/Delete/5
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
                return View();
            }
        }
    }
}
