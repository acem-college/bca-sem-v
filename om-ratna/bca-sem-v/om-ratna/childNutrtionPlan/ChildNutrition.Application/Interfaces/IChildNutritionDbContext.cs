namespace ChildNutrition.Application.Interfaces
{
    public interface IChildNutritionDbContext
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
