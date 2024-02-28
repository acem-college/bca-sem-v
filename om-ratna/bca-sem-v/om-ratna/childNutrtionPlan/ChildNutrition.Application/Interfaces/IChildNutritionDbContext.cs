using ChildNutrition.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ChildNutrition.Application.Interfaces
{
    public interface IChildNutritionDbContext
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        DbSet<Comment> Comments { get; set; }
    }
}
