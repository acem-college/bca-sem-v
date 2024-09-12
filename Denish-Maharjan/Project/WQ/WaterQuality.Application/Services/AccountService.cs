using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using WaterQuality.Application.Interface;
using WaterQualityMVC.ui.Controllers.Accounts;

namespace WaterQuality.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IIdentityService _iIdentityService;
        public AccountService(IIdentityService identityService)
        {
            _iIdentityService = identityService;
        }
        public async Task<ClaimsPrincipal> LogInAsync(LogInVm logIn, CancellationToken cancellationToken)
        {
            var result = await _iIdentityService.AuthenticateAsync(logIn, cancellationToken);
            return result;
        }

        public async Task<bool> SignUpAsync(SignUpVm signUp, CancellationToken cancellationToken)
        {
            await _iIdentityService.UserSignUpAsync(signUp, cancellationToken);
            return true;
            
        }

        
    }
}
