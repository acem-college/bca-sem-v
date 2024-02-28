using Mental.Application.Interfaces;
using Mental.Application.Models.Accounts;
using Mental.Application.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mental.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IIdentityService _identityService;
        public AccountService(IIdentityService identityService)
        {
            _identityService = identityService;
        }
        public async Task<bool> LoginAsync(LoginVM loginVM, CancellationToken cancellationToken)
        {
            var result = await _identityService.AuthenticateAsync(loginVM, cancellationToken);
            return result;
        }

        public async Task<bool> SignUpAsync(SignUpVM signUpVM, CancellationToken cancellationToken)
        {
            await _identityService.UserSignUpAsync(signUpVM, cancellationToken);
            return true;
        }
    }


}
