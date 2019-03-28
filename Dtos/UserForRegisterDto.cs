namespace API.Dtos
{
    public class UserForRegisterDto
    {
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string IDNumber { get; set; }
        public string Username { get; set; }
        public string Password { get; set; } 
        public int IsAdmin { get; set; }
    }
}