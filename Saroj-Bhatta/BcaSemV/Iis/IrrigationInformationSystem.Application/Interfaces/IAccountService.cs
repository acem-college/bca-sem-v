using IrrigationInformationSystem.Application.Models.Account;
using System.Security.Claims;

namespace IrrigationInformationSystem.Application.Interfaces
{
    public interface IAccountService
    {
        Task<ClaimsPrincipal> LogInAsync(LogInVM login, CancellationToken cancellationToken);
        Task<bool> SignUpAsync(SignUpVM signup, CancellationToken cancellationToken);
    }
}
