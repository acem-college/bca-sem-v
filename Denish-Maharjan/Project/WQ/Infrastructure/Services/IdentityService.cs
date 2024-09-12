using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using WaterQuality.Application.Interface;
using WaterQuality.Application.Models.Users;
using WaterQuality.Domain.Entities;
using WaterQualityMVC.ui.Controllers.Accounts;

namespace Infrastructure.Services
{
    public class IdentityService : IIdentityService
    {
        private readonly UserManager<User> _userManager;
        public IdentityService(UserManager<User> userManager) 
        {
            _userManager = userManager;
        }

       

        public async Task<string> CreateAsync(CreateUserVM user, CancellationToken cancellationToken)
        {
            var dbUser = new User();
            dbUser.FirstName= user.FirstName;
            dbUser.LastName= user.LastName;
            dbUser.DOB = user.DOB;
            dbUser.UserName = user.Username;
            dbUser.Email= user.Email;
            dbUser.PasswordHash = user.Password;
            dbUser.PasswordHash = user.ConfirmPassword;
            var result=await _userManager.CreateAsync(dbUser);
            if (result.Succeeded)
            {
                return dbUser.Id;
            }
            
            throw new Exception("Error occured while creating user");
        }
        public async Task<string> UserSignUpAsync(SignUpVm user, CancellationToken cancellationToken)
        {
            var dbUser = new User();
            dbUser.FirstName = user.FirstName;
            dbUser.LastName = user.LastName;
            dbUser.DOB = user.DOB;
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

        public async Task<bool> UpdateAsync(int id, UpdateUserVM user, CancellationToken cancellation)
        {

            var dbUser = new User();
            if (dbUser == null)
            {
                throw new Exception("User not found!!");
            }
            dbUser.FirstName = user.FirstName;
            dbUser.LastName = user.LastName;
            dbUser.DOB = user.DOB;
            dbUser.UserName = user.Username;
            dbUser.Email = user.Email;
            var result = await _userManager.UpdateAsync(dbUser);
            if (result.Succeeded)
            {
                return result.Succeeded;
            }
            throw new Exception("Error occured while updating user");
        }

        
        public async Task<ClaimsPrincipal> AuthenticateAsync(LogInVm logIn, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByNameAsync(logIn.Username);
            if (user==null)
            {
                throw new Exception("Invalid username or password");
            }
            var result = await _userManager.CheckPasswordAsync(user, logIn.Password);
            if (!result)
            {
                throw new Exception("Invalid Username or Password");
            }

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, $"{user.Id}"),
                new Claim(ClaimTypes.Name,$"{user.FirstName} {user.LastName}" ),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Role,"Admin"),
            };

            var principal = new ClaimsPrincipal();
            principal.AddIdentity(new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme));
            return principal;
        }
    }
}
