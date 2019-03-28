using System;

namespace API.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string IDNumber { get; set; }
        public string Username { get; set; }
        public int IsAdmin { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}