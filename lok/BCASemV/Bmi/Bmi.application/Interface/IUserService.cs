using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bmi.Application.Models.Users;

namespace Bmi.Application.Interface
{
	public interface IUserService
	{
		Task<List<UserVM>> ListAsync(CancellationToken cancellationToken);
		Task<UserVM> GetAsync(int id, CancellationToken cancellationToken);
		Task<string> CreateAsync(CreateUserVM user, CancellationToken cancellationToken);
		Task<bool> UpdateAsync(int id, UpdateUserVM user, CancellationToken cancellationToken);
		Task<bool> DeleteAsync(int id, CancellationToken cancellationToken);
	}
}
