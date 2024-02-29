using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Pim.Application.Interfaces;
using Pim.Application.Models.Accounts;
using Pim.Application.Models.Users;
using Pim.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Pim.Infrastructure.Services
{
    public class IdentityService : IIdentityservice
    {
        public async Task<string> CreateAsync(CreateUserVM user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            var dbUser = new User();
            dbUser.FirstName = user.FirstName;
            dbUser.LastName = user.LastName;
            dbUser.Email = user.Email;
            dbUser.UserName = user.Username;
            dbUser.DOB = user.DateOfBirth;

            var result = await _UserManager.CreateAsync(dbUser);
            if (result.Succeeded)
            {
                return dbUser.Id;
            }
            throw new Exception("Error Occur");


        }

        public Task<UserVM> GetAsync(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserVM>> listAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        Task<int> IIdentityservice.CreateAsync(CreateUserVM user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        private readonly UserManager<User> _UserManager;
        private object await_usermanager;

        public IdentityService(UserManager<User> userManager)
        {
            _UserManager = userManager;
        }


        public async Task<ClaimsPrincipal> AuthenticateAsync(LogInVm login, CancellationToken cancellationToken)
        {
            var User = await _UserManager.FindByNameAsync(login.Username);
            if (User == null)
            {
                throw new Exception("Invalid Username or Password");
            }
            var claims = new List<Claim>
            {
            new Claim(ClaimTypes.NameIdentifier,$"{User.Id}"),
            new Claim(ClaimTypes.Name,$"{User.FirstName}{User.LastName}"),
            new Claim(ClaimTypes.Email,User.Email),
            new Claim(ClaimTypes.Role,"Admin"),

            };
            var principal = new ClaimsPrincipal();
            principal.AddIdentity(new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme));
            return principal;

        }
    }

}

