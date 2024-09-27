using AirQualityIndex.Application.Models.Accounts;
using AirQualityIndex.Application.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AirQualityIndex.Application.Interfaces
{
    public interface IIdentityService
    {
        Task<List<UserVM>> ListAsync(CancellationToken cancellationToken);
        Task<UserVM> GetAsync(int id, CancellationToken cancellationToken);
        Task<string> CreateAsync(CreateUserVM user, CancellationToken cancellationToken);
        Task<bool> UpdateAsync(int id, UpdateUserVM user, CancellationToken cancellationToken);
        Task<bool> DeleteAsync(int id, CancellationToken cancellationToken);
        Task<ClaimsPrincipal> AuthenticateAsync(LoginVM login, CancellationToken cancellationToken);
        Task<String> UserSignUpAsync(SignUpVM user, CancellationToken cancellationToken);
    }
}
