using IrrigationInformationSystem.Application.Interfaces;
using IrrigationInformationSystem.Application.Models.Account;
using System.Security.Claims;

namespace IrrigationInformationSystem.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IIdentityService _identityService;
        public AccountService(IIdentityService identityService)
        {
            _identityService = identityService;
        }

        public async Task<ClaimsPrincipal> LogInAsync(LogInVM login, CancellationToken cancellationToken)
        {
            var result = await _identityService.AuthenticateAsync(login, cancellationToken);
            return result;
        }

        public async Task<bool> SignUpAsync(SignUpVM signup, CancellationToken cancellationToken)
        {
            await _identityService.UserSignUpAsync(signup, cancellationToken);
            return true;
        }
    }

}
