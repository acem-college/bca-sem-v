using IrrigationInformationSystem.Application.Models.Account;
using IrrigationInformationSystem.Application.Models.Users;

namespace IrrigationInformationSystem.Application.Interfaces
{
    public interface IIdentityService
    {
        Task<List<UserVM>> ListAsync(CancellationToken cancellationToken);
        Task<UserVM> GetAsync(int id, CancellationToken cancellationToken);
        Task<string> CreateAsync(CreateUserVM User, CancellationToken cancellationToken);
        Task<string> UserSignUpAsync(SignUpVM user, CancellationToken cancellationToken);
        Task<bool> UpdateAsync(int id, UpdateUserVM User, CancellationToken cancellationToken);
        Task<bool> DeleteAsync(int id, CancellationToken cancellationToken);
        Task<bool> AuthenticateAsync(LogInVM login, CancellationToken cancellationToken);
    }
}
