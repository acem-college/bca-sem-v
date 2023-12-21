using Classwork.MVC.Application.Model.User;

namespace Classwork.MVC.Application.Interfaces
{
    public interface IUserService
    {
        Task<List<ListUserVM>>ListAsync(CancellationToken cancellationToken);
    }
}
