using Infant.Application.Models.Account;
using Infant.Application.Interfaces;
using Infant.Application.Models.Users;
using Infant.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace Infant.Infrastructure.Services
{
    public class IdentityService : IIdentityServices
    {
        private readonly UserManager<User> _userManager;
        public IdentityService(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task<string> CreateAsync(CreateUserVm user, CancellationToken cancellationToken)
        {
            var dbUser = new User();
            dbUser.FirstName = user.FirstName;
            dbUser.LastName = user.LastName;
            dbUser.Email = user.Email;
            dbUser.UserName = user.UserName;
            dbUser.DateofBirth = user.DateofBirth;
            var result = await _userManager.CreateAsync(dbUser, user.Password);
            if (result.Succeeded)
            {
                return dbUser.Id;
            }

            throw new Exception("Error occurred while creating user.");

        }

        public async Task<bool> AuthenticateAsync(LoginVM login, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByNameAsync(login.UserName);

            if (user == null)
            {
                throw new Exception("Invalid UserName or Password");
            }

            var result = await _userManager.CheckPasswordAsync(user, login.Password);
            return result;

        }

        public Task<List<UserVm>> ListAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<UserVm> GetAsync(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<string> UserSignUpAsync(SignUpVM user, CancellationToken cancellationToken)
        {
            var dbUser = new User();
            dbUser.FirstName = user.FirstName;
            dbUser.LastName = user.LastName;
            dbUser.Email = user.Email;
            dbUser.UserName = user.UserName;
            dbUser.DateofBirth = user.DOB;
            var result = await _userManager.CreateAsync(dbUser, user.Password);
            if (result.Succeeded)
            {
                return dbUser.Id;
            }

            throw new Exception("Error occurred while creating user.");
        }

        public Task<bool> UpdateAsync(int id, UpdateUserVm user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}