using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pim.Application.Interfaces;
using Pim.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pim.Infrastructure.Persistence
{
    public class PIMDbContext : IdentityDbContext<User>, IPimDbContext
    {
        public PIMDbContext(DbContextOptions<PIMDbContext> options) : base(options) { }
        public DbSet<Comment> Comments { get; set; }

    }
   
}
