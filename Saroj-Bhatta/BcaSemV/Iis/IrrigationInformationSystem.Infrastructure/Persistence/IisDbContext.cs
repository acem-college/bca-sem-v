using IrrigationInformationSystem.Application.Interfaces;
using IrrigationInformationSystem.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IrrigationInformationSystem.Infrastructure.Persistence
{
    public class IisDbContext : IdentityDbContext<User>, IIisDbContext
    {
        public IisDbContext(DbContextOptions<IisDbContext> options) : base(options) { }
       public DbSet<Comment> Comments { get; set; }
    }
}
