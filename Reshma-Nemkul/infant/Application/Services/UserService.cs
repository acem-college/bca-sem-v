using Infant.Application.Interfaces;
using Infant.Application.Models.Users;
using Infant.Application.Sevices;
using Infant.Domain.Entities;
using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infant.Application.Sevices
{
    public class UserService : IUserServices
    {
        private readonly IIdentityServices _identityService;
        public UserService(IIdentityServices identityService)
        {
            _identityService = identityService;

        }

        public Task<string> CreateAsync(CreateUserVm user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<string> CreateAysnc(CreateUserVm user, CancellationToken cancellationToken)
        {

            var result = await _identityService.CreateAsync(user, cancellationToken);
            return result;
        }

        public Task<bool> DeleteAsync(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserVm>> GetAsync(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserVm>> ListAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(int id, UpdateUserVm user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        Task<UserVm> IUserServices.GetAsync(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        Task<List<bool>> IUserServices.UpdateAsync(int id, UpdateUserVm user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

 
        