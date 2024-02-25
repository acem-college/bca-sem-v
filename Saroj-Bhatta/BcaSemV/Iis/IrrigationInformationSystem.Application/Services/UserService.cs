using IrrigationInformationSystem.Application.Interfaces;
using IrrigationInformationSystem.Application.Models.Users;
using IrrigationInformationSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrrigationInformationSystem.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IIdentityService _identityService;
        public UserService (IIdentityService identityService)
        {
            _identityService = identityService;
        }
        public async Task<string> CreateAsync(CreateUserVM User, CancellationToken cancellationToken)
        {
            var result = await _identityService.CreateAsync(User, cancellationToken);
            return result;
            throw new NotImplementedException();
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
    }
}