using Infant.Application.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infant.Application.Interfaces
{
    public interface IUserServices
    {
        Task<List<UserVm>> ListAsync(CancellationToken cancellationToken);

        Task<UserVm> GetAsync(int id, CancellationToken cancellationToken);

        Task<string> CreateAsync(CreateUserVm user, CancellationToken cancellationToken);

        Task<List<bool>> UpdateAsync(int id, UpdateUserVm user, CancellationToken cancellationToken);

        Task<bool> DeleteAsync(int id, CancellationToken cancellationToken);
    }
}
