using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using WaterConsumptionSystem.Application.Models.Accounts;

namespace WaterConsumptionSystem.Application.Interfaces
{
    public interface IAccountsServices
    {
        Task<ClaimsPrincipal>LoginAsync(LoginVM Login, CancellationToken cancellationToken);
        Task<bool> SignUpAsync(SignUpVM SignUp, CancellationToken cancellationToken);
    }
}
