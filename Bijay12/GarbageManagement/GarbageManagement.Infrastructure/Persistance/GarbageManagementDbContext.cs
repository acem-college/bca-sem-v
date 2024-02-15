using Garbagemanagement.Application.Interfaces;
using GarbageManagement.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;


namespace GarbageManagement.Infrastructure.Persistance
{
    public class GarbageManagementDbContext : IdentityDbContext<User>, IGarbageManagementDbContext
    {
        public GarbageManagementDbContext(DbContextOptions<GarbageManagementDbContext> options) : base(options) { }

        public Task<int> saveChangesAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
