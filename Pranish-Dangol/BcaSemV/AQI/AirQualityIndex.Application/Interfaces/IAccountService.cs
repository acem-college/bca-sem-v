using AirQualityIndex.Application.Models.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AirQualityIndex.Application.Interfaces
{
    public interface IAccountService
    {
        Task<ClaimsPrincipal> LoginAsync(LoginVM login, CancellationToken cancellationToken);
        Task<bool> SignUpAsync(SignUpVM signup, CancellationToken cancellationToken);
    }
}
