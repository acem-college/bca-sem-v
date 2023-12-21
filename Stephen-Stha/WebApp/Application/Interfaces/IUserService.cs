using LifeOnLand.Application.Models.User;

namespace LifeOnLand.Application.Interfaces
{
    public interface IUserService
    {
        Task<List<ListUserVM>> ListAsync(CancellationToken cancellationToken);
    }
}
