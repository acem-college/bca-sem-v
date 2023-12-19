
using MyMVCApp.UI.Application.Model;

namespace MyMVCApp.UI.Application.Interfaces
{
    public interface IUserService
    {
        Task<List<ListUserVm>> ListsAsync(CancellationToken cancellationToken);
    }
}
