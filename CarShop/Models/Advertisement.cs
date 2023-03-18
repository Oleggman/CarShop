namespace CarShop.Models
{
    public class Advertisement
    {
        public int Id { get; set; }

        public bool ActivityStatus { get; set; }

        public bool IsFavourite { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public ushort ReleaseYear { get; set; }

        public uint Run { get; set; }

        public string Description { get; set; }

        public uint Price { get; set; }

        public int UserToken { get; set; }

        public string Img { get; set; }

        public string FullName { get; set; }

        public string Phone { get; set; }
    }
}