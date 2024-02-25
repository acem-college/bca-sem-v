using IrrigationInformationSystem.Application.Interfaces;
using IrrigationInformationSystem.Application.Models.Account;
using IrrigationInformationSystem.Application.Models.Users;
using IrrigationInformationSystem.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            dbUser.Username = User.Username;
            dbUser.Email = User.Email;
            var result = await _userManager.CreateAsync(dbUser);
            if (result.Succeeded)
            {
                return dbUser.Id;
            }
            throw new Exception("Error While Creating a User");
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

        public Task<bool> UpdateAsync(int id, UpdateUserVM User, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> AuthenticateAsync(LogInVM login, CancellationToken cancellationToken)
        {
            var User = await _userManager.FindByNameAsync(login.Username);
            if (User == null)
            {
                throw new Exception("Invalid Username or Password");
            }
            var result = await _userManager.CheckPasswordAsync(User, login.Password);
            return result;
        }

    }
}
