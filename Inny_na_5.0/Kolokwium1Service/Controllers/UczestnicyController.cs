using Kolokwium1Service.Models;
using Kolokwium1Storage.Dtos;
using Kolokwium1Storage.Entities;
using Kolokwium1Storage.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Kolokwium1Service.Controllers
{
    public class UczestnicyController : Controller
    {
        private readonly IUczestnicyService _uczestnicyService;
        public UczestnicyController(IUczestnicyService uczestnicyService)
        {
            _uczestnicyService = uczestnicyService;
        }
        // GET: UczestnicyContoller
        public ActionResult Index()
        {
            var result = _uczestnicyService.Read();
            return View(result);
        }
        // GET: UczestnicyContoller/Create
        public ActionResult Create()
        {
            var model = new UczestnicyAddModel();
            model.Konkursy = _uczestnicyService.ReadKonkursy().Select(konkurs => new SelectListItem
            {
                Text = konkurs.Nazwa,
                Value = konkurs.Id.ToString(),
            }).ToList();
            return View(model);
        }
        // POST: UczestnicyContoller/Create
        [HttpPost]
        public ActionResult Create(UczestnicyAddModel model)
        {
            if (ModelState.IsValid)
            {
                _uczestnicyService.Create(model);
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        // GET: UczestnicyContoller/Update/5
        public ActionResult Update(int id)
        {
            var uczestnik = _uczestnicyService.Read().FirstOrDefault(x => x.Id == id);
            Console.WriteLine("Uczestnik", id, uczestnik.Id);
            var model = new UczestnicyAddModel()
            {
                Id = uczestnik.Id,
                Imie = uczestnik.Imie,
                Nazwisko = uczestnik.Nazwisko,
                Email = uczestnik.Email,
                KonkursId = uczestnik.KonkursId
            };
            model.Konkursy = _uczestnicyService.ReadKonkursy().Select(konkurs => new SelectListItem
            {
                Text = konkurs.Nazwa,
                Value = konkurs.Id.ToString(),
            }).ToList();
            return View(model);
        }

        // POST: UczestnicyContoller/Update/5
        [HttpPost]
        public ActionResult Update(int id, UczestnicyAddModel model)
        {
            if (ModelState.IsValid)
            {
                _uczestnicyService.Update(model);
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        // POST: UczestnicyContoller/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            Console.WriteLine("Siema:" + id);
            _uczestnicyService.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
