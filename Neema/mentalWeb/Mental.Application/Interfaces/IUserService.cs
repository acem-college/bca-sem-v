using Mental.Application.Models.Users;

namespace Mental.Application.Interfaces
{
    internal interface IUserService
    {
        Task<List<UserVM>> ListAsync(CancellationToken cancellationToken);

        Task<UserVM> GetAsync(int id, CancellationToken cancellationToken);

        Task<string> CreateAsync(CreateUserVM user, CancellationToken cancellationToken);

        Task<List<bool>> UpdateAsync(int id, UpdateUserVM user, CancellationToken cancellationToken);

        Task<bool> DeleteAsync(int id, CancellationToken cancellationToken);
    }
}
