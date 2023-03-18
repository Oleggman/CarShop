using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using CarShop.Data;
using Microsoft.Extensions.DependencyInjection;

namespace CarShop.Models
{
    public class ShopCart
    {
        private readonly DBContent dbContent;

        public ShopCart(DBContent dbContent)
        {
            this.dbContent = dbContent;
        }

        public string ShopCartId { get; set; }

        public List<ShopCartItem> ListShopItems { get; set; }

        public static ShopCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<DBContent>();
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", shopCartId);

            return new ShopCart(context) { ShopCartId = shopCartId };
        }

        public void AddToCart(Advertisement ad)
        {
            dbContent.ShopCartItem.Add(new ShopCartItem
            {
                ShopCartId = ShopCartId,
                Brand = ad.Brand,
                Model = ad.Model,
                Description = ad.Description,
                Img = ad.Img,
                Price = ad.Price
            });

            dbContent.SaveChanges();
        }

        public List<ShopCartItem> GetShopItems()
        {
            return dbContent.ShopCartItem.Where(c => c.ShopCartId == ShopCartId).Include(s => s.Advertisement).ToList();
        }
    }
}
