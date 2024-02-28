using IrrigationInformationSystem.Application.Interfaces;
using IrrigationInformationSystem.Application.Models.Account;
using IrrigationInformationSystem.Application.Models.Users;
using IrrigationInformationSystem.Domain.Entities;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
<<<<<<< HEAD
=======

>>>>>>> a87f4f70fe29f9fc5fba85573f185ee3917da05f
namespace IrrigationInformationSystem.Infrastructure.Services
{
    public class IdentityService : IIdentityService

    {
        private readonly UserManager<User> _userManager;
        public IdentityService(UserManager<User> userManager)
        {
            _userManager = userManager;
        }
        public async Task<string> CreateAsync(CreateUserVM User, CancellationToken cancellationToken)
        {
            var dbUser = new User();
            dbUser.FirstName = User.FirstName;
            dbUser.LastName = User.LastName;
            dbUser.DateOfBirth = User.DateOfBirth;
            dbUser.UserName = User.Username;
            dbUser.Email = User.Email;
            var result = await _userManager.CreateAsync(dbUser);
            if (result.Succeeded)
            {
                return dbUser.Id;
            }
            throw new Exception("Error While Creating a User");
        }
<<<<<<< HEAD
=======

>>>>>>> a87f4f70fe29f9fc5fba85573f185ee3917da05f
        public async Task<string> UserSignUpAsync(SignUpVM user, CancellationToken cancellationToken)
        {
            var dbUser = new User();
            dbUser.FirstName = user.FirstName;
            dbUser.LastName = user.LastName;
            dbUser.DateOfBirth = user.DateOfBirth;
            dbUser.UserName = user.Username;
            dbUser.Email = user.Email;
            var result = await _userManager.CreateAsync(dbUser, user.Password);
            if (result.Succeeded)
            {
                return dbUser.Id;
            }
            throw new Exception("Error While Creating a User");
        }
<<<<<<< HEAD
=======

>>>>>>> a87f4f70fe29f9fc5fba85573f185ee3917da05f
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

        public async Task<bool> UpdateAsync(int id, UpdateUserVM user, CancellationToken cancellationToken)
        {
            var dbUser=new User();
            if (dbUser == null) {
                throw new Exception("User not found!!");
            }
            dbUser.FirstName = user.FirstName;
            dbUser.LastName = user.LastName;
            dbUser.DateOfBirth = user.DateOfBirth;
            dbUser.UserName = user.Username;
            dbUser.Email = user.Email;
            var result = await _userManager.UpdateAsync(dbUser);
            if (result.Succeeded)
            {
                return result.Succeeded;
            }
            throw new Exception("Error occured while updating user");
        }
<<<<<<< HEAD
=======

>>>>>>> a87f4f70fe29f9fc5fba85573f185ee3917da05f
        public async Task<ClaimsPrincipal> AuthenticateAsync(LogInVM login, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByNameAsync(login.Username);
            if (user == null)
            {
                throw new Exception("Invalid Username or Password");
            }
            var result = await _userManager.CheckPasswordAsync(user, login.Password);
            if (!result)
            {
                throw new Exception("Invalid Username or Password");
            }

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, $"{user.Id}"),
                new Claim(ClaimTypes.Name,$"{user.FirstName} {user.LastName}" ),
                new Claim(ClaimTypes.Email, user.Email),
            };

            var principal = new ClaimsPrincipal();
            principal.AddIdentity(new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme));
            return principal;
        }

    }
}
