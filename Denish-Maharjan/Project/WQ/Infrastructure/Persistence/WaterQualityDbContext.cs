using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterQuality.Application.Interface;
using WaterQuality.Domain.Entities;

namespace Infrastructure.Persistence
{
    public class WaterQualityDbContext : IdentityDbContext<User>, IWQDbContext
    {
        public WaterQualityDbContext(DbContextOptions<WaterQualityDbContext> options): base(options) { }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Bagmati> Bagmati { get; set; }
    }
}
