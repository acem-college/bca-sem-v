using IrrigationInformationSystem.Application.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrrigationInformationSystem.Application.Interfaces
{
    public interface IAccountService
    {
        Task<bool> LogInAsync(LogInVM login, CancellationToken cancellationToken);
        Task<bool> SignUpAsync(SignUpVM signup, CancellationToken cancellationToken);
    }
}
