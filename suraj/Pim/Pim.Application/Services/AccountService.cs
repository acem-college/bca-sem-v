using Pim.Application.Interfaces;
using Pim.Application.Models.Accounts;
using System.Security.Claims;

namespace Pim.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IIdentityservice _identityService;
        public AccountService(IIdentityservice identityService)
        {
            _identityService = identityService;
        }

       public async Task<ClaimsPrincipal> LogInAsync(LogInVm logIn, CancellationToken cancellationToken)
        {
            var result = await _identityService.AuthenticateAsync(logIn, cancellationToken);
            return result;
        }

        public async Task<bool> SignUpAsync(SignUpVm signUp, CancellationToken cancellationToken)
        {
            await _identityService.UserSignUpAsync(signUp, cancellationToken);
            return true;
        }
    }
}
