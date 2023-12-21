namespace Classwork.MVC.Domain.Entity
{
    public class UserProfile
    {
       
        public Guid id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string phone { get; set; }
       
        public string address { get; set; }
        
        public UserProfile() { }
        static void Main(string[] args)
        {
            UserProfile obj = new UserProfile();
        }
    }
     
}
