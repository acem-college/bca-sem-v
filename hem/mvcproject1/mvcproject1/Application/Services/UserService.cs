using mvcproject1.Application.Interfaces;
using mvcproject1.Application.Model.User;
using mvcproject1.Infrastructure.Persistence;

namespace mvcproject1.Application.Service
{
    public class UserService : IUserServices
    {
        public async Task<List<ListUserVM>> ListAsync(CancellationToken cancellationToken)
        {

            var users = Users.Profiles.Select(s => new ListUserVM
            {
                Email = s.Email,
                FirstName = s.FirstName,
                LastName = s.LastName,
                Id = s.Id,
                PhoneNumber = s.PhoneNumber,
            }.ToList();

            return (List<ListUserVM>)users;
        }
        public async Task CreateAsync(SaveUserVM user, CancellationToken cancellationToken)
        {
            Users.Profiles.Add(new Domain.Entities.UserProfile
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber

            });

        }
        public async Task<SaveUserVM> GetAsync(Guid userId, CancellationToken CancellationToken)
        {
            var user = Users.Profiles.Where(w => w.Id == userId)
                .Select(s => new SaveUserVM
                {
                    Id = s.Id,
                    FirstName = s.FirstName,
                    LastName = s.LastName,
                    Email = s.Email,
                    PhoneNumber = s.PhoneNumber,
                }).FirstOrDefault();
            return user;
        }
    }
}



