namespace WebApp.Application.Models.User
{
    public class ListUserVM
    {
        public Guid Id { get; internal set; }
        public string Email { get; internal set; }
        public string address { get; set; }
        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
        public string PhoneNumber { get; internal set; }
    }
}


