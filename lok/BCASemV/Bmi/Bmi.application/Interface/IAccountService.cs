using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Bmi.Application.Models.Accounts;

namespace Bmi.Application.Interface
{
    public interface IAccountService
    {
        Task<ClaimsPrincipal> LoginAsync(LoginVM Login, CancellationToken cancellationToken);
        Task<bool> SignUpAsync(SignUpVM signUp, CancellationToken cancellationToken);
    }
}
