using Mental.Application.Interfaces;
using Mental.Application.Models.Users;

namespace Mental.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IIdentityService _identityService;
        public UserService (IIdentityService identityService)
        {
            _identityService = identityService;
        }
        
        public async Task<string> CreateAsync(CreateUserVM user, CancellationToken cancellationToken)
        {
            var result = await _identityService.CreateAsync(user, cancellationToken);
            return result;
            
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

        public Task<List<bool>> UpdateAsync(int id, UpdateUserVM user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
