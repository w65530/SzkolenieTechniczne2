using AnimalsService.Models;
using AnimalsStorage.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AnimalsService.Controllers
{
    public class AnimalsController : Controller
    {
        private readonly IAppService _appService;
        public AnimalsController(IAppService appService)
        {
            _appService = appService;
        }
        public IActionResult Index()
        {
            var animals = _appService.Read();
            return View(animals);
        }
        public IActionResult Create()
        {
            var model = new AddAnimalModel();
            model.AnimalTypes = _appService.ReadTypes().Select(type => new SelectListItem()
            {
                Value = type.Id.ToString(),
                Text = type.Name
            }).ToList();
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(AddAnimalModel animal)
        {
            if (ModelState.IsValid)
            {
                _appService.Create(animal);
                return RedirectToAction(nameof(Index));
            }
            return View(animal);
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var animal = _appService.Read().FirstOrDefault(animal => animal.Id == id);
            if (!animal.ChildrenInCage)
            {
                _appService.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
