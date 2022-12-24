using asp_tut_mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace asp_tut_mvc.Controllers
{
    public class FirstController : Controller
    {
        static List<DogViewModel> DogViewModels { get; set; }
        public IActionResult Index()
        {
            if (DogViewModels == null) DogViewModels = new List<DogViewModel>();
            return View(DogViewModels);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            DogViewModels.Add(dogViewModel);
            return RedirectToAction(nameof(Index));
        }

        public string Str()
        {
            return "some str";
        }
    }
}
