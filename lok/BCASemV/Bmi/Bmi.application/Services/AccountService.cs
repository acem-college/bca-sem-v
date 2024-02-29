using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Bmi.Application.Interface;
using Bmi.Application.Models.Accounts;

namespace Bmi.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IIdentityServices _identityServices;
        public AccountService(IIdentityServices identityServices)
        {
            _identityServices = identityServices;
            
        }

        public async Task<bool> SignUpAsync(SignUpVM signUp, CancellationToken cancellationToken)
        {
            await _identityServices.UserSignUpAsync(signUp, cancellationToken);
            return true;
        }

        public async Task<ClaimsPrincipal> LoginAsync(LoginVM Login, CancellationToken cancellationToken)
        {
            var result = await _identityServices.AuthenticateAsync(Login, cancellationToken);
            return result;
        }
    }
}
