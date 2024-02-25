using IrrigationInformationSystem.Application.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrrigationInformationSystem.Application.Interfaces
{
    public interface IUserService
    {
        Task<List<UserVM>> ListAsync(CancellationToken cancellationToken);
        Task<UserVM> GetAsync(int id, CancellationToken cancellationToken);
         Task<string> CreateAsync(CreateUserVM User, CancellationToken cancellationToken);
         Task<bool> UpdateAsync(int id,UpdateUserVM User ,CancellationToken cancellationToken);
         Task<bool> DeleteAsync(int id, CancellationToken cancellationToken);
    }
}
