using Cloth_Bank.Application.Interfaces;
using Cloth_Bank.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Cloth_Bank.Infrastructure.Persistence
{
    public class Cloth_BankDbContext : IdentityDbContext<User>, ICloth_BankDbContext
    {
        public Cloth_BankDbContext(DbContextOptions<Cloth_BankDbContext> options) : base(options) { }

        public Task<int> savevChangeAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
