using Infant.Application.Models.Account;
using Infant.Application.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infant.Application.Interfaces
{
    public interface IIdentityServices
    {
        Task<List<UserVm>> ListAsync(CancellationToken cancellationToken);
        Task<UserVm> GetAsync(int id, CancellationToken cancellationToken);
        Task<string> CreateAsync(CreateUserVm user, CancellationToken cancellationToken);
        Task<string> UserSignUpAsync(SignUpVM user, CancellationToken cancellationToken);
        Task<bool> UpdateAsync(int id, UpdateUserVm user, CancellationToken cancellationToken)scsc
        Task<bool> DeleteAsync(int id, CancellationToken cancellationToken);
        Task<bool> AuthenticateAsync(LoginVM login, CancellationToken cancellationToken);

    }
}
