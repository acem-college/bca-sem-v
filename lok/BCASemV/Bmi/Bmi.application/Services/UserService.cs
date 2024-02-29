using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bmi.Application.Interface;
using Bmi.Application.Models.Users;

namespace Bmi.Application.Services
{
	public class UserService : IUserService
	{
		private readonly IIdentityServices _identityservice;
		public UserService(IIdentityServices identityServices)
		{
			_identityservice = identityServices;
		}
		
		
		public async Task<int> CreateAsync(CreateUserVM user, CancellationToken cancellationToken)
		{
			var result= await _identityservice.CreateAsync(user, cancellationToken);
			return result;
			throw new NotImplementedException();
		}

		public Task<bool> DeleteAsync(int id, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		public Task<UserVM> GetAsync(int id, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		public Task<List<UserVM>> ListAsync(CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		public Task<bool> UpdateAsync(int id, UpdateUserVM user, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		Task<string> IUserService.CreateAsync(CreateUserVM user, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}
	}
}
