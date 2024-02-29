using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Bmi.Application.Models.Accounts;
using Bmi.Application.Models.Users;

namespace Bmi.Application.Interface
{
	public interface IIdentityServices
	{
		Task<List<UserVM>> ListAsync(CancellationToken cancellationToken);
		Task<UserVM> GetAsync(int id, CancellationToken cancellationToken);
		Task<int> CreateAsync(CreateUserVM user, CancellationToken cancellationToken);
		Task<bool> UpdateAsync(int id, UpdateUserVM user, CancellationToken cancellationToken);
		Task<bool> DeleteAsync(int id, CancellationToken cancellationToken);
		Task<ClaimsPrincipal> AuthenticateAsync(LoginVM login, CancellationToken cancellationToken);
		Task<string> UserSignUpAsync(SignUpVM user, CancellationToken cancellationToken);

    }
}
