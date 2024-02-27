using Infant.Application.Interfaces;
using Infant.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infant.Infrastructure.persistence
{
    public class InfantDbContext : IdentityDbContext<User>, IInfantDbContext
    {
        public InfantDbContext(DbContextOptions<InfantDbContext> options) : base(options) { }
    }
}
