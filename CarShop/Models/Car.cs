namespace CarShop.Models
{
    public class Car
    {
        public int Id { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public ushort ReleaseYear { get; set; }

        public uint Run { get; set; }

        public string Description { get; set; }

        public uint Price { get; set; }

        public int UserToken { get; set; }
    }
}