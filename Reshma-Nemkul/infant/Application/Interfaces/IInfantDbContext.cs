namespace Infant.Application.Interfaces
{
    public interface IInfantDbContext
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
