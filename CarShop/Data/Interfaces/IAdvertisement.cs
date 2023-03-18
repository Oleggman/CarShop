using CarShop.Models;

namespace CarShop.Data.Interfaces
{
    public interface IAdvertisement
    {
        IEnumerable<Advertisement> Ads { get; }

        IEnumerable<Advertisement> FavAds { get; }

        User User(int userId);
    }
}
