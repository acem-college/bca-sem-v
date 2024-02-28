using AirQualityIndex.Application.Interfaces;
using AirQualityIndex.Application.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirQualityIndex.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IIdentityService _identityService;
        public UserService(IIdentityService identityService)
        {
            _identityService = identityService;
        }

        public Task<bool> DeleteAsync(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<string>CreateAsync(CreateUserVM user, CancellationToken cancellationToken)
        {
            var result = await _identityService.CreateAsync(user, cancellationToken);
            return result;
        }

        public async Task<UserVM> GetAsync(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<List<UserVM>> ListAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateAsync(int id, UpdateUserVM user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
