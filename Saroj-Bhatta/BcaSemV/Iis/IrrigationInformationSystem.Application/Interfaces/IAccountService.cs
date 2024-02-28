using IrrigationInformationSystem.Application.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace IrrigationInformationSystem.Application.Interfaces
{
    public interface IAccountService
    {
        Task<ClaimsPrincipal> LogInAsync(LogInVM login, CancellationToken cancellationToken);
        Task<bool> SignUpAsync(SignUpVM signup, CancellationToken cancellationToken);
    }
}
