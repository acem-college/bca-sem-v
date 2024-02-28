using Mental.Application.Interfaces;
using Mental.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class MentalDbContext : IdentityDbContext<User>, IMentalDbContext
    {
        public DbSet<Comment> Comments { get; set; }
        public MentalDbContext(DbContextOptions<MentalDbContext> options) : base(options) { }
    }

   
}
