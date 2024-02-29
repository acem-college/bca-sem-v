using Pim.Application.Models.Accounts;
using Pim.Application.Models.Users;
using System.Security.Claims;

namespace Pim.Application.Interfaces
{
    public interface IIdentityservice
    {
        Task<List<UserVM>> listAsync(CancellationToken cancellationToken);
        Task<UserVM> GetAsync(int id, CancellationToken cancellationToken);
        Task<int> CreateAsync(CreateUserVM user, CancellationToken cancellationToken);
        Task<bool> UpdateAsync(int id, CancellationToken cancellationToken);
        Task<ClaimsPrincipal> AuthenticateAsync(LogInVm login, CancellationToken cancellationToken);
    }
}
