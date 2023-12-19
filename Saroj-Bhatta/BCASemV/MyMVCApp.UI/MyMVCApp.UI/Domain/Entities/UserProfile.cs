using System;
namespace MyMVCApp.UI.Domain.Entities
{
    public class UserProfile {
        public UserProfile()
        { }
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }

       
}


