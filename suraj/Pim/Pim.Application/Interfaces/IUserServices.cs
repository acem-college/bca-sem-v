using Pim.Application.Models.Users;

namespace Pim.Application.Interfaces
{
    public interface IUserServices
    {
        Task<List<UserVM>> ListAsync(CancellationToken cancellationToken);
        Task<UserVM> GetAsync(string id, CancellationToken cancellationToken);
        Task<string> CreateAsync(CreateUserVM user, CancellationToken cancellationToken);
        Task<bool> UpdateAsync(string id, UpdateUserVM user, CancellationToken cancellationToken);
        Task<bool> DeleteAsyc(string id, CancellationToken cancellationToken);
    }
}
