using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterQuality.Application.Models.Users;

namespace WaterQuality.Application.Interface
{
    public interface IUserService
    {
        Task<List<UserVM>> ListAsync(CancellationToken cancellationToken);
        Task<UserVM> GetAsync(int id, CancellationToken cancellationToken);
        Task<string> CreateAsync(CreateUserVM user, CancellationToken cancellationToken);
        Task<bool> UpdateAsync(int id, UpdateUserVM user, CancellationToken cancellation);
        Task<bool> DeleteAsync(int id, CancellationToken cancellationToken);
    }
}
