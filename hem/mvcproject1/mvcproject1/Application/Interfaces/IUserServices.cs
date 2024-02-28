using mvcproject1.Application.Model.User;

namespace mvcproject1.Application.Interfaces
{
    public interface IUserServices
    { 
        Task<List<ListUserVM>> ListAsync(CancellationToken cancellationToken);
    }
}

