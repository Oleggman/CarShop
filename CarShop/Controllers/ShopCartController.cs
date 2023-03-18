using CarShop.Migrations;
using Microsoft.AspNetCore.Mvc;
using CarShop.Models;
using CarShop.ViewModels;
using CarShop.Data.Interfaces;

namespace CarShop.Controllers
{
    public class ShopCartController : Controller
    {
        private readonly IAdvertisement _carRep;

        private readonly Models.ShopCart _shopCart;

        public ShopCartController(IAdvertisement carRep, Models.ShopCart shopCart)
        {
            _carRep = carRep;
            _shopCart = shopCart;
        }

        public ViewResult Index()
        {
            var items = _shopCart.GetShopItems();
            _shopCart.ListShopItems = items;

            var obj = new ShopCartViewModel
            {
                ShopCart = _shopCart
            };

            return View(obj);

        }

        public RedirectToActionResult AddToCart(int id)
        {
            var item = _carRep.Ads.FirstOrDefault(x => x.Id == id);

            if (item != null) {
                _shopCart.AddToCart(item);            
            }

            return RedirectToAction("Index");
        }
    }
}
