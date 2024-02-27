using ChildNutrition.Application.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildNutrition.Application.Interfaces
{
    public interface IUserService
    {
        Task<List<UserVM>> ListAsync(CancellationToken CancellationToken);
        Task<UserVM> GetAsync(int id, CancellationToken CancellationToken);
        Task<string> CreateAsync(CancellationToken CancellationToken);
        Task<bool> UpdateAsync(int id, UpdateUserVM user, CancellationToken CancellationToken);
        Task<bool> DeleteAsync(int id, CancellationToken CancellationToken);
    }
}
