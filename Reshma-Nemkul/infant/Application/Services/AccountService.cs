using Infant.Application.Models.Account;
using Infant.Application.Interfaces;
namespace Infant.Application.Services
{
    public class AccountService : IAccountServices
    {
        private readonly IIdentityServices _iIdentityService;
        public AccountService(IIdentityServices identityService)
        {
            _iIdentityService = identityService;
        }
        public async Task<bool> LoginAsync(LoginVM loginVM, CancellationToken cancellationToken)
        {
            var result = await _iIdentityService.AuthenticateAsync(loginVM, cancellationToken);
            return result;
        }

        public async Task<bool> SignUpAsync(SignUpVM SignUpVM, CancellationToken cancellationToken)
        {
            var result = await _iIdentityService.UserSignUpAsync(SignUpVM, cancellationToken);
            return true;

        }
    }


}
