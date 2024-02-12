using ChildNutrition.Application.Interfaces;
using ChildNutrition.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ChildNutrition.Infrastructure.Persistence
{
    public class ChildNutritionDbContext : IdentityDbContext<User>, IChildNutritionDbContext
    {
        public ChildNutritionDbContext(DbContextOptions<ChildNutritionDbContext> options) : base(options) { }
    }
}
