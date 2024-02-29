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

        async Task<ClaimsPrincipal> IAccountService.LogInAsync(LogInVm logIn, CancellationToken cancellationToken)
        {
            var result = await _identityService.AuthenticateAsync(logIn, cancellationToken);
            return result;
        }

        Task<bool> IAccountService.SignUpAsync(SignUpVm signUp, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
