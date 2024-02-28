﻿using ChildNutrition.Application.Interfaces;
using ChildNutrition.Application.Models.Accounts;
using ChildNutrition.Application.Models.Users;
using ChildNutrition.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace ChildNutrition.Infrastructure.UserService
{
    public class IdentityService : IIdentityService
    {
        private readonly UserManager<User> _userManager;
        public IdentityService(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task<bool> AuthenticateAsync(LogInVM login, CancellationToken CancellationToken)
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
            dbUser.FirstName = user.FirstName;
            dbUser.LastName = user.LastName; ;
            dbUser.Email = user.Email;
            dbUser.UserName = user.UserName;
            
            var result = await _userManager.CreateAsync(dbUser,user.Password);
            if (result.Succeeded)
            {
                return dbUser.Id;

            }
            throw new Exception("wasup!!error while creating user!!!");
        }

        public Task<bool> DeleteAsync(int id, CancellationToken CancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<UserVM> GetAsync(int id, CancellationToken CancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserVM>> ListAsync(CancellationToken CancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<string> UserSignUpAsync(SignUpVM user, CancellationToken cancellationToken)
        {
            var dbUser = new User();
            dbUser.FirstName = user.FirstName;
            dbUser.LastName = user.LastName; ;
            dbUser.Email = user.Email;
            dbUser.UserName = user.Username;
            dbUser.DateOfBirth = user.DateOfBirth;
           
            var result = await _userManager.CreateAsync(dbUser, user.Password);
            if (result.Succeeded)
            {
                return dbUser.Id;

            }
            throw new Exception("wasup!! error while creating user!!!");
        }

        Task<bool> IIdentityService.UpdateAsync(int id, UpdateUserVM user, CancellationToken CancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

