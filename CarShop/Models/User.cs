namespace CarShop.Models
{
    public class User
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public ushort Age { get; set; }

        public string City { get; set; }

        public string Phone { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public int UserToken { get; set; }
    }
}