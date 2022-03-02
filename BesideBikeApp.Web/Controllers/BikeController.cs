using BesideBike.Application.Interfaces;
using BesideBike.Application.Viewmodels;
using BesideBike.Domain.Model;
using Microsoft.AspNetCore.Mvc;

namespace BesideBikeApp.Web.Controllers
{
    public class BikeController : Controller
    {
        private readonly IBikeService _bikeService;

        public BikeController(IBikeService bikeService)
        {
            _bikeService = bikeService;
        }
        [HttpGet]
        public IActionResult Index()
        {
           var listOfBikes =  _bikeService.GetAllBikes();
            return View(listOfBikes);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var bikeToDisplay = _bikeService.GetBikeForEdit(id);
            return View(bikeToDisplay);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(BikesVM bike)
        {
            if (!ModelState.IsValid)
            {
                return View("Edit",bike);
            }
            _bikeService.Update(bike);
            return RedirectToAction("Index");
        }


    }
}
