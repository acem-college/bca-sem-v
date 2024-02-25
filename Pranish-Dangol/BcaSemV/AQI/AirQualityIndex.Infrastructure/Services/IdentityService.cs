using AirQualityIndex.Application.Interfaces;
using AirQualityIndex.Application.Models.Accounts;
using AirQualityIndex.Application.Models.Users;
using AirQualityIndex.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace AirQualityIndex.Infrastructure.Services
{
    public class IdentityService : IIdentityService
    {
        private readonly UserManager<User> _userManager;
        public IdentityService(UserManager<User> userManager) 
        { 
         _userManager = userManager;
        }

        public  async Task<bool> AuthenticateAsync(LoginVM login, CancellationToken cancellationToken)
        {
            var User = await _userManager.FindByNameAsync(login.UserName);
            if (User == null)
            {
                throw new Exception("Invalid Username or password");
            }
            var result = await _userManager.CheckPasswordAsync(User, login.Password);
            return result;
        }

        public async Task<string> CreateAsync(CreateUserVM user, CancellationToken cancellationToken)
        {
            var dbUser = new User();
            dbUser.FirstName = user.FirstName;
            dbUser.LastName = user.LastName;
            dbUser.DateOfBirth = user.DateOfBirth;
            dbUser.UserName = user.UserName;
            dbUser.Email = user.Email;

            var result= await _userManager.CreateAsync(dbUser);
            if (result.Succeeded)
            {
                return dbUser.Id;
            }
            throw new Exception("Error occured while creating user");

        }

        public Task<bool> DeleteAsync(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<UserVM> GetAsync(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<List<UserVM>> ListAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateAsync(int id, UpdateUserVM user, CancellationToken cancellationToken)
        {
            var dbUser = new User();
            if (dbUser == null)
            {
                throw new Exception("User not found");
            }
            dbUser.FirstName = user.FirstName;
            dbUser.LastName = user.LastName;
            dbUser.DateOfBirth = user.DateOfBirth;
            dbUser.UserName = user.UserName;
            dbUser.Email = user.Email;

            var result = await _userManager.UpdateAsync(dbUser);

            return result.Succeeded;
            
            throw new Exception("Error occured while updating user");
        }

    }
}
