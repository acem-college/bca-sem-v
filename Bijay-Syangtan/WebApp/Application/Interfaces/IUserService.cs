using WebApp.Application.Models.User;

namespace WebApp.Application.Interfaces
{
    public interface IUserService
    {
        Task<List<ListUserVM>> ListAsync(CancellationToken cancellationToken);
    }
}
