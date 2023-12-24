using ClassCheck.Ui.Application.Models.User;

namespace ClassCheck.Ui.Application.Interfaces
{
    public interface IUserServie
    {
        Task<List<ListUserVM>> ListAsync(CancellationToken cancellationToken);
    }
}
