using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterConsumptionSystem.Application.Interfaces;
using WaterConsumptionSystem.Application.Models.Users;

namespace WaterConsumptionSystem.Application.Services
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
            var result = await _identityService.CreateAsync(user, cancellationToken);
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

        public Task<bool> UpdateAsync(int id, UpdateUserVM user, CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
    
    

