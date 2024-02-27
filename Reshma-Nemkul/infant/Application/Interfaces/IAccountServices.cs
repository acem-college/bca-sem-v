using Infant.Application.Models.Account;

namespace Infant.Application.Interfaces
{
    public  interface IAccountServices
    {
        Task<bool> LoginAsync(LoginVM loginVM, CancellationToken cancellationToken);
        Task<bool> SignUpAsync(SignUpVM signUpVM, CancellationToken cancellationToken);
    }
}
