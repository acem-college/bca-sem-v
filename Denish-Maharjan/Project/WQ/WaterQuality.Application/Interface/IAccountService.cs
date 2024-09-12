using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using WaterQualityMVC.ui.Controllers.Accounts;

namespace WaterQuality.Application.Interface
{
    public interface IAccountService
    {
        Task<ClaimsPrincipal>LogInAsync(LogInVm login, CancellationToken cancellationToken);
        
        Task<bool> SignUpAsync(SignUpVm signUp,CancellationToken cancellationToken);
    }
}
