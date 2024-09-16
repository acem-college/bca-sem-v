using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using WaterConsumptionSystem.Application.Interfaces;
using WaterConsumptionSystem.Application.Models.Accounts;
using WaterConsumptionSystem.Application.Models.Users;
using WaterConsumptionSystem.Domain.Entities;

namespace WaterConsumptionSystem.Infrastructure.Services
{
    public class IdentityService : IIdentityService
    {
        private readonly UserManager<User> _userManager;
        public IdentityService(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task<ClaimsPrincipal> AuthenticateAsync(LoginVM Login, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByNameAsync(Login.Username);
            if (user == null)
            {
                throw new Exception("Invalid Username or Password");
            }
            var result = await _userManager.CheckPasswordAsync(user, Login.Password);
            if (!result)
            {
                throw new Exception("Invalid Username or Password");
            }

            var claims = new List<Claim>
            {
                new  Claim(ClaimTypes.NameIdentifier, $"{user.Id}"),
                new  Claim(ClaimTypes.Name, $"{user.FirstName} {user.LastName}"),
                new  Claim(ClaimTypes.Email, $"{user.Email}"),
                new Claim(ClaimTypes.Role,"Admin"),
            };
            var principal = new ClaimsPrincipal();
            principal.AddIdentity(new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme));
                return principal;
        }
        

        public async Task<string> UserSignUpAsync(SignUpVM user, CancellationToken cancellationToken)
        {
            var dbUser = new User();
            dbUser.FirstName = user.FirstName;
            dbUser.LastName = user.LastName;
            dbUser.Email = user.Email;
            dbUser.DateOfBirth = user.DateOfBirth;
            dbUser.UserName = user.Username;
            dbUser.Email = user.Email;
            dbUser.PasswordHash = user.Password;
            dbUser.PasswordHash = user.ConfirmPassword;
            var result = await _userManager.CreateAsync(dbUser, user.Password);
            if (result.Succeeded)
            {
                return dbUser.Id;
            }
            throw new Exception("Error while creating user");
        }
        
        public async Task<string> CreateAsync(CreateUserVM user, CancellationToken cancellationToken)
        {
            var dbUser = new User();
            dbUser.FirstName = user.FirstName;
            dbUser.LastName = user.LastName;
            dbUser.DateOfBirth = user.DateOfBirth;
            dbUser.Email = user.Email;
            dbUser.UserName = user.Username;

            var result = await _userManager.CreateAsync(dbUser);
            if (result.Succeeded)
            {
                return dbUser.Id;
            }
            throw new Exception("Error Occured while creating the user");
        }

        public Task<List<UserVM>> ListAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<UserVM> GetAsync(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
