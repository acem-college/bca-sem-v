using AirQualityIndex.Mvc.Ui.Application.Models.User;

namespace AirQualityIndex.Mvc.Ui.Application.Interfaces
{
    public interface IUserService
    {
        Task<List<ListUserVM>> ListsAsync(CancellationToken cancellationToken);
    }
}
