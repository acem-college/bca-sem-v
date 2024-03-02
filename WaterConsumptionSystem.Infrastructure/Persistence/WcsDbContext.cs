using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using WaterConsumptionSystem.Application.Interfaces;
using WaterConsumptionSystem.Domain.Entities;

namespace WaterConsumptionSystem.Infrastructure.Persistence
{
    public class WcsDbContext : IdentityDbContext<User>,IwcsDbContext
    {
        public WcsDbContext(DbContextOptions<WcsDbContext> options):base(options) { }
       public DbSet<Comment> Comments { get; set; }
    }
}
