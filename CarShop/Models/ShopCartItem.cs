namespace CarShop.Models
{
    public class ShopCartItem
    {
        public int Id { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public string Description { get; set; }

        public string Img { get; set; }

        public uint Price { get; set; }

        public string ShopCartId { get; set; }

        public Advertisement Advertisement { get; set; }
    }
}
