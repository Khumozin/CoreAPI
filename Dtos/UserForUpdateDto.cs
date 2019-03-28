namespace API.Dtos
{
    public class UserForUpdateDto
    {
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string IDNumber { get; set; }
        public string Username { get; set; }
        public int IsAdmin { get; set; }
    }
}