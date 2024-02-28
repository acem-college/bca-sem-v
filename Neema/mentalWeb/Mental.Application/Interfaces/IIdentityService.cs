using Mental.Application.Models.Accounts;
using Mental.Application.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mental.Application.Interfaces
{
    public interface IIdentityService
    {
        Task<List<UserVM>> ListAsync(CancellationToken cancellationToken);

        Task<UserVM> GetAsync(int id, CancellationToken cancellationToken);

        Task<string> CreateAsync(CreateUserVM user, CancellationToken cancellationToken);
        Task<string>UserSignUpAsync(SignUpVM user, CancellationToken cancellationToken);
        Task<List<bool>> UpdateAsync(int id, UpdateUserVM user, CancellationToken cancellationToken);

        Task<bool> DeleteAsync(int id, CancellationToken cancellationToken);
        Task<bool> AuthenticateAsync(LoginVM login, CancellationToken cancellationToken);

    }
}
