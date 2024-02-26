using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterConsumptionSystem.Application.Interfaces;
using WaterConsumptionSystem.Application.Models.Accounts;

namespace WaterConsumptionSystem.Application.Services
{
    public class AccountService : IAccountsServices
    {
        private readonly IIdentityService _iIdentityService;
        public AccountService(IIdentityService identityService)
        {
            _iIdentityService = identityService;
        }

        public Task<bool> Login(LoginVM LoginVM, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> LoginAsync(LoginVM LoginVM, CancellationToken cancellationToken)
        {

            var result = await _iIdentityService.AuthenticateAsync(LoginVM, cancellationToken);
            return result;
        }

        public async Task<bool> SignUpAsync(SignUpVM signUp, CancellationToken CancellationToken)
        {
            await _iIdentityService.UserSignUpAsync(signUp, CancellationToken);
            return true;

        }

        public Task<bool> SignUp(SignUpVM SignUpVM, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
