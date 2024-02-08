using Bbi.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bbi.Infrastructure.Persistence
{
    public class BbiDbContext : IdentityDbContext<User>
    {
        public BbiDbContext (DbContextOptions<BbiDbContext> options) : base(options) { }
    }
}
