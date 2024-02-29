using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WaterQuality.Application.Interface;
using WaterQuality.Application.Models.Users;
using WaterQuality.Domain.Entities;

namespace WaterQuality.Application.Services
{
    public class UserService : IUserService
   
    {
        private readonly IIdentityService _identityService;
        public UserService(IIdentityService identityService)
        {
            _identityService = identityService;
        }
        

        public async Task<string> CreateAsync(CreateUserVM user, CancellationToken cancellationToken)
        {
            var result=await _identityService.CreateAsync(user, cancellationToken);
            return result;
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteAsync(int id, CancellationToken cancellationToken)
        {
            var result = await _identityService.DeleteAsync(id, cancellationToken);
            return result;
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

        public async Task<bool> UpdateAsync(int id, UpdateUserVM user , CancellationToken cancellationToken)
        {
            var result = await _identityService.UpdateAsync(id, user,cancellationToken);
            return result;
            throw new NotImplementedException();
        }
    }
}
