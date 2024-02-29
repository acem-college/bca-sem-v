using IrrigationInformationSystem.Application.Interfaces;
using IrrigationInformationSystem.Application.Models.Users;
using IrrigationInformationSystem.Domain.Entities;

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

        public async Task<bool> UpdateAsync(int id, UpdateUserVM User, CancellationToken cancellationToken)
        {
            var result = await _identityService.UpdateAsync(id, User, cancellationToken);
            return result;
            throw new NotImplementedException();
        }
    }
}