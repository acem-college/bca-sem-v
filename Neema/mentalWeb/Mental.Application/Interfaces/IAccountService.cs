using Mental.Application.Models.Accounts;

namespace Mental.Application.Interfaces
{
    public interface IAccountService
    {
        Task<bool> LoginAsync(LoginVM loginVM, CancellationToken cancellationToken);
        Task<bool> SignUpAsync(SignUpVM signUpVM, CancellationToken cancellationToken);
    }
}
