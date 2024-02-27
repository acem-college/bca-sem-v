using ChildNutrition.Application.Interfaces;
using ChildNutrition.Application.Models.Users;

namespace ChildNutrition.Application.Services
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
            {
                return result.ToString();
            }
            throw new NotImplementedException();
        }

        public Task<int> CreateAsync(CancellationToken CancellationToken)
        {
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

        Task<string> IUserService.CreateAsync(CancellationToken CancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

