using Mental.Application.Interfaces;
using Mental.Application.Models.Accounts;
using Mental.Application.Models.Users;
using Mental.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Services
{
    public class IdentityService : IIdentityService
    {
        private readonly UserManager<User> _userManager;
        public IdentityService(UserManager<User>userManager)
        {
           _userManager = userManager;
        }

        public async Task<bool> AuthenticateAsync(LoginVM login, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByNameAsync(login.UserName);
            if (user == null)
            {
                throw new Exception("Invalid username or password.");
            }
            var result = await _userManager.CheckPasswordAsync(user, login.Password);
            return result;
        }

        public async Task<string> CreateAsync(CreateUserVM user, CancellationToken cancellationToken)
        {
            var dbUser = new User();
            dbUser.FirstName= user.FirstName;
            dbUser.LastName= user.LastName;
            dbUser.Email= user.Email;
            dbUser.DOB = user.DOB;
            dbUser.UserName= user.UserName;

           var result= await _userManager.CreateAsync(dbUser, user.Password);
           if (result.Succeeded)
            {
                return dbUser.Id;
            }
            throw new Exception("error");
        }
        public async Task<string> UserSignUpAsync(SignUpVM user,CancellationToken cancellationToken)
        {
            var dbUser = new User();
            dbUser.FirstName= user.FirstName;
            dbUser.LastName= user.LastName; 
            dbUser.Email= user.Email;
            dbUser.UserName = user.UserName;
            dbUser.DOB= user.DOB;
            var result = await _userManager.CreateAsync(dbUser,user.Password);
            if (result.Succeeded)
            {
                return dbUser.Id;   
            }
            throw new Exception("Error while creating a User");
        }
        public Task<bool> DeleteAsync(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<UserVM> GetAsync(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserVM>> ListAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<bool>> UpdateAsync(int id, UpdateUserVM user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
