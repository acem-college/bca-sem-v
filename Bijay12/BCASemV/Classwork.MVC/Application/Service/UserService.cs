using Classwork.MVC.Application.Interfaces;
using Classwork.MVC.Application.Model.User;

namespace Classwork.MVC.Application.Service
{
    public class UserService : IUserService
    {
        public async Task<List<ListUserVM>> ListAsync(CancellationToken cancellationToken)
        {
          var users = new List<ListUserVM>();
            users.Add(new ListUserVM()
            {
                id = Guid.NewGuid(),
                name = "Bijay",
                email = "bijay.123@gmail.com",
                phone = "987655677",
                address = "naikap"
            }) ;
            return users;
        }
        public async Task<ListUserVM>CreateAsync(SaveUserVM user ,CancellationToken cancellationToken)
        {
            var userVM = new ListUserVM
            {
                id = user.id,
                name = user.name,
                email = user.email,
                phone = user.phone,
                address = user.address

            };
            return userVM;
        }

    }
}


