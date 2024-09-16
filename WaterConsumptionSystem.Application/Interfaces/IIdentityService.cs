using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using WaterConsumptionSystem.Application.Models.Accounts;
using WaterConsumptionSystem.Application.Models.Users;

namespace WaterConsumptionSystem.Application.Interfaces
{
    public interface IIdentityService
    {
        Task<List<UserVM>> ListAsync(CancellationToken cancellationToken);
        Task<UserVM> GetAsync(int id, CancellationToken cancellationToken);
        Task<string> CreateAsync(CreateUserVM user, CancellationToken cancellationToken);
        Task<string>UserSignUpAsync(SignUpVM user, CancellationToken cancellationToken);
        Task<bool> UpdateAsync(int id, CancellationToken cancellationToken);
        Task<bool> DeleteAsync(int id, CancellationToken cancellationToken);

        Task<ClaimsPrincipal>AuthenticateAsync(LoginVM Login, CancellationToken cancellationToken);
    }
}
