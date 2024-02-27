using ChildNutrition.Application.Interfaces;
using ChildNutrition.Application.Models.Accounts;

namespace ChildNutrition.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IIdentityService _identityService;
        public AccountService(IIdentityService identityService)
        {
            _identityService = identityService;
        }

        public async Task<bool> LogInAsync(LogInVM logIn, CancellationToken cancellationToken)
        {
            var result = await _identityService.AuthenticateAsync(logIn, cancellationToken);
            return result;
        }

        public async Task<bool> SignUpAsync(SignUpVM signUp, CancellationToken cancellationToken)
        {
            await _identityService.UserSignUpAsync(signUp, cancellationToken);
            return true;
        }
    }
}
