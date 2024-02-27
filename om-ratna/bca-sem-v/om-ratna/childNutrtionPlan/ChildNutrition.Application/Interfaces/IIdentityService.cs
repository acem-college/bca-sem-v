using ChildNutrition.Application.Models.Accounts;
using ChildNutrition.Application.Models.Users;

namespace ChildNutrition.Application.Interfaces
{
    public interface IIdentityService
    {
        Task<List<UserVM>> ListAsync(CancellationToken CancellationToken);
        Task<UserVM> GetAsync(int id, CancellationToken CancellationToken);
        Task<string> CreateAsync(CreateUserVM user, CancellationToken CancellationToken);
        Task<bool> UpdateAsync(int id, UpdateUserVM user, CancellationToken CancellationToken);
        Task<bool> DeleteAsync(int id, CancellationToken CancellationToken);
        Task<bool> AuthenticateAsync(LogInVM login, CancellationToken CancellationToken);
        Task<string> UserSignUpAsync(SignUpVM user, CancellationToken cancellationToken);

    }

}
