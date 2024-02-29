using Microsoft.EntityFrameworkCore;
using Pim.Domain.Entities;

namespace Pim.Application.Interfaces
{
    public interface IPimDbContext
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        DbSet<Comment> Comments { get; set; }

    }
}
