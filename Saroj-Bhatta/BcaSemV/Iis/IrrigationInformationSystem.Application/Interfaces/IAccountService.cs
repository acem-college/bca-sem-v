using IrrigationInformationSystem.Application.Models.Account;
<<<<<<< HEAD
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
=======
using System.Security.Claims;
>>>>>>> a87f4f70fe29f9fc5fba85573f185ee3917da05f

namespace IrrigationInformationSystem.Application.Interfaces
{
    public interface IAccountService
    {
        Task<ClaimsPrincipal> LogInAsync(LogInVM login, CancellationToken cancellationToken);
        Task<bool> SignUpAsync(SignUpVM signup, CancellationToken cancellationToken);
    }
}
