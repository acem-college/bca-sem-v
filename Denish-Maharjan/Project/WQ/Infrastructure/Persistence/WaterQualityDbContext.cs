using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterQuality.Domain.Entities;

namespace Infrastructure.Persistence
{
    internal class WaterQualityDbContext : IdentityDbContext<User>
    {
        public WaterQualityDbContext(DbContextOptions<WaterQualityDbContext> options): base(options) { }
    }
}
