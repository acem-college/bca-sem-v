using AirQualityIndex.Application.Models.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirQualityIndex.Application.Interfaces
{
    public interface IAccountService
    {
        Task<bool> LoginAsync(LoginVM login, CancellationToken cancellationToken);
        Task<string> SignUpAsync(SignUpVM signup, CancellationToken cancellationToken);
    }
}
