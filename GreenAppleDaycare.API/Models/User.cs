namespace GreenAppleDaycare.API.Models
{
    public class User
    {
        public int id { get; set; }
        public string Username { get; set; }
        public byte[] passwordHash { get; set; }
        public byte[] passwordSalt { get; set; }
    }
}