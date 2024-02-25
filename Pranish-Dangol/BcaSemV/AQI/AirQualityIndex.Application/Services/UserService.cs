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

        Task<UserVM> IUserService.GetAsync(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        Task<List<UserVM>> IUserService.ListAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        Task<bool> IUserService.UpdateAsync(int id, UpdateUserVM user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
