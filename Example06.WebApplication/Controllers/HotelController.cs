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
        private ILogger<HotelController> _logger;
        public HotelController(AppDbContext appDbContext, ILogger<HotelController> logger)
        {
            _appDbContext = appDbContext;
            _logger=logger;
        }

        // GET: HotelController
        public ActionResult Index()
        {
            var oteller=_appDbContext.Otels.ToList();
            _logger.LogInformation("Oteller sayfası listeleniyor toplam otel sayısı: " + oteller.Count);
            _logger.LogError("Oteller sayfası listeleniyor toplam otel sayısı: " + oteller.Count);
            _logger.LogWarning("Oteller sayfası listeleniyor toplam otel sayısı: " + oteller.Count);
            _logger.LogCritical("Oteller sayfası listeleniyor toplam otel sayısı: " + oteller.Count);
            return View(oteller);
        }

        // GET: HotelController/Details/5
        public ActionResult Details(int id)
        {
            Otel model = _appDbContext.Otels.Single(o => o.Id == id);

            Hotel hotel = new Hotel();
            hotel.Id = model.Id;
            hotel.Name = model.Name;
            hotel.Description = model.Description;
            hotel.Phone = model.Phone;
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
            Otel model = _appDbContext.Otels.Single(o => o.Id == id);

            return View(model);
        }

        // POST: HotelController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Otel newmodel)
        {
            try
            {
                Otel oldModel = _appDbContext.Otels.Single(o => o.Id == id);
                oldModel.Name= newmodel.Name;
                oldModel.Description= newmodel.Description;
                oldModel.Phone= newmodel.Phone;

                _appDbContext.Otels.Update(oldModel);
                _appDbContext.SaveChanges();

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
            Otel Model = _appDbContext.Otels.Single(o => o.Id == id);

            return View(Model);
        }

   
        public ActionResult DeleteConfirm2(int id)
        {
            try
            {
                Otel Model = _appDbContext.Otels.Single(o => o.Id == id);
                _appDbContext.Otels.Remove(Model);
                _appDbContext.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // POST: HotelController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id)
        {
            try
            {
                Otel Model=_appDbContext.Otels.Single(o => o.Id == id);
                _appDbContext.Otels.Remove(Model);
                _appDbContext.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
