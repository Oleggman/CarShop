using CarShop.Data.Interfaces;
using CarShop.Models;
using System.Data.Entity;

namespace CarShop.Data.Repository
{
    public class CarRepository : IAdvertisement
    {
        private readonly DBContent dbContent;

        public CarRepository(DBContent dbContent)
        {
            this.dbContent = dbContent;
        }

        public IEnumerable<Advertisement> Ads => dbContent.Ads.Include(c => c.ActivityStatus);
        public IEnumerable<Advertisement> FavAds => dbContent.Ads.Where(p => p.IsFavourite).Include(c => c.ActivityStatus);
        public User User(int userId) => dbContent.Users.FirstOrDefault(p => p.Id == userId);
    }
}
