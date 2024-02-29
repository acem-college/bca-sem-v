using Bmi.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Bmi.Application
{
    public interface IBmiDbContext
	{
		Task<int> SaveChangesAsync(CancellationToken cancellationToken);
		DbSet<Comment>Comments { get; set; }
	}
}
