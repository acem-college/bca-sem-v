using webApplication.Application.Model.User;


namespace webApplication.Application.Inerfaces
{
    public interface IUserServices
    {
        Task<List<ListUserVM>> ListAsync(CancellationToken cancellationToken);
    }
}
