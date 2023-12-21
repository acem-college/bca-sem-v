using webapp.Application.Model.User;
namespace webapp.Application.Interface
{
    public interface IUserService
    {
        Task<List<ListUserVM>> ListAsync(CancellationToken cancellationToken);
    }
}
