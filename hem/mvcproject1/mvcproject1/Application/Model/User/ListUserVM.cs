namespace mvcproject1.Application.Model.User
{
    public class ListUserVM
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        internal object ToList()
        {
            throw new NotImplementedException();
        }
    }
}

