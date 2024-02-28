using AirQualityIndex.Application.Interfaces;
using AirQualityIndex.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirQualityIndex.Infrastructure.Persistence
{
    public class AqiDbContext : IdentityDbContext<User>,
        IAqiDbContext
    {
        public AqiDbContext (DbContextOptions<AqiDbContext> options) : base(options) { }

        public DbSet<Comment> Comments { get; set; }
    }
}
