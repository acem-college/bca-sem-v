using webApplication.Application.Model.User;


namespace webApplication.Application.Inerfaces
{
    public interface IUserServices
    {
        Task<SaveUserVM> GetAsync(Guid userId, CancellationToken cancellationToken);
        Task<List<ListUserVM>> ListAsync(CancellationToken cancellationToken);
    }
}
