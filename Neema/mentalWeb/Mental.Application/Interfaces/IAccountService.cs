using Mental.Application.Models.Accounts;
using System.Security.Claims;

namespace Mental.Application.Interfaces
{
    public interface IAccountService
    {
        Task<ClaimsPrincipal> LoginAsync(LoginVM loginVM, CancellationToken cancellationToken);
        Task<bool> SignUpAsync(SignUpVM signUpVM, CancellationToken cancellationToken);
    }
}
