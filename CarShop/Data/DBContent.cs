using CarShop.Models;
using Microsoft.EntityFrameworkCore;

namespace CarShop.Data
{
    public class DBContent : DbContext
    {
        public DBContent(DbContextOptions<DBContent> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        public DbSet<Advertisement> Ads { get; set; }
        
        public DbSet<ShopCartItem> ShopCartItem { get; set; }

    }
}
