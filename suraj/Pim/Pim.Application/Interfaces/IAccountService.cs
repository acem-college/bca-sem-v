using Pim.Application.Models.Accounts;
using System.Security.Claims;

namespace Pim.Application.Interfaces
{

    public interface IAccountService

    {
        Task<ClaimsPrincipal> LogInAsync(LogInVm logIn, CancellationToken cancellationToken);
        Task<bool> SignUpAsync(SignUpVm signUp, CancellationToken cancellationToken);
    }
}
