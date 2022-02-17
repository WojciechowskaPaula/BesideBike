using BesideBike.Application.Interfaces;
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

        public IActionResult Index()
        {
           var listOfBikes =  _bikeService.GetAllBikes();
            return View(listOfBikes);
        }
    }
}
