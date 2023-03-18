using CarShop.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CarShop.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAdvertisement _ads;

        public CarsController(IAdvertisement ads)
        {
            _ads = ads;
        }

        public IActionResult List()
        {
            ViewBag.Ad = "Останні оголошення";
            var advertisements = _ads.Ads;

            return View(advertisements);
        }
    }
}
