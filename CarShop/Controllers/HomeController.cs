using CarShop.Data.Interfaces;
using CarShop.Data.Repository;
using CarShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CarShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAdvertisement _carRep;

        public HomeController(IAdvertisement carRep, Models.ShopCart shopCart)
        {
            _carRep = carRep;
        }

        public ViewResult Index()
        {
            ViewBag.Ad = "Обрані автомобілі";

            var homeCars = new HomeViewModel
            {
                FavAds = _carRep.FavAds,
            };

            return View(homeCars);
        }
    }
}
