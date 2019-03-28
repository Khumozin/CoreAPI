namespace API.Dtos
{
    public class DependantForUpdate
    {
        public int DependantID { get; set; }
        public int MainMemberID { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string IDNumber { get; set; }
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Relationship { get; set; }
    }
}