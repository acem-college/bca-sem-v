using System.Security.Claims;
using System.Security.Principal;
using Bmi.Application.Interface;
using Bmi.Application.Models.Accounts;
using Bmi.Application.Models.Users;
using Bmi.Domain.Entities;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;

namespace Bmi.Infrastructure.Services
{
    public class IdentityServices : IIdentityServices
    {
        private readonly UserManager<User> _userManager;

        public IdentityServices(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task<string> CreateAsync(CreateUserVM user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            var dbUser = new User();
            dbUser.FirstName = user.FirstName;
            dbUser.LastName = user.LastName;
            dbUser.Email = user.Email;
            dbUser.UserName = user.UserName;
            dbUser.DOB = user.DOB;

            var result = await _userManager.CreateAsync(dbUser);
            if (result.Succeeded)
            {
                return dbUser.Id;
            }
            throw new Exception("Error occur");
        }

        public async Task<ClaimsPrincipal> AuthenticateAsync(LoginVM login, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByNameAsync(login.UserName);
            if (user == null)
            {
                throw new Exception("Invalid UserName or Password");
            }
            
            var claims = new List<Claim>
        {
            new Claim(ClaimTypes.NameIdentifier,$"{user.Id}"),
            new Claim(ClaimTypes.Name,$"{user.FirstName}{user.LastName}"),
            new Claim(ClaimTypes.Email,user.Email),
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
            dbUser.DOB = user.DOB;
            dbUser.UserName = user.UserName;

            var result = await _userManager.CreateAsync(dbUser, user.Password);
            if (result.Succeeded)
                return dbUser.Id;

            throw new Exception("error while using a user");


        }

        public Task<List<UserVM>> ListAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<UserVM> GetAsync(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        Task<int> IIdentityServices.CreateAsync(CreateUserVM user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(int id, UpdateUserVM user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}





