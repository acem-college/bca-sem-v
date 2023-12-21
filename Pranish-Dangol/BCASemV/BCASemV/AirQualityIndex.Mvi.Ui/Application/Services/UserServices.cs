using AirQualityIndex.Mvc.Ui.Application.Interfaces;
using AirQualityIndex.Mvc.Ui.Application.Models.User;

namespace AirQualityIndex.Mvc.Ui.Application.Services
{
    public class UserServices : IUserService
    {
        public async Task<List<ListUserVM>> ListsAsync(CancellationToken cancellationToken)
        {
            var users = new List<ListUserVM>();
            users.Add(new ListUserVM
            {
                Id = Guid.NewGuid(),
                FirstName = "Pranish",
                LastName = "Dangol",
                Email = "Pranish@gmail.com",
                PhoneNumber = "9863728373"
            });
            return users;

        }
        public async Task<ListUserVM> CreateAsync(SaveUserVM user, CancellationToken cancellationToken)
        {
            var userVM = new ListUserVM
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber
            };
            return userVM;
        }
    }
}
