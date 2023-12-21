namespace AirQualityIndex.Mvc.Ui.Domain.Entities
{
    public class UserProfile
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        static void Main(string[] args)
        {
            UserProfile userProfile = new UserProfile();
        }



    }
}
