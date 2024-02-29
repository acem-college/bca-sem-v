using Pim.Application.Interfaces;
using Pim.Application.Models.Users;
using Pim.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Pim.Application.Services
{
    public class UserService : IUserServices
    {
        private readonly IIdentityservice _identityservice;
        public UserService(IIdentityservice identityservice)
        {
            _identityservice = identityservice;
        }
      
        public async Task<string> CreateAsync(CreateUserVM user, CancellationToken cancellationToken)
        {
            var result = await _identityservice.CreateAsync(user, cancellationToken);
            return result.ToString();
            throw new NotImplementedException();
            
        }

        public Task<bool> DeleteAsyc(string id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<UserVM> GetAsync(string id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserVM>> ListAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(string id, UpdateUserVM user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        }
   
   
}
