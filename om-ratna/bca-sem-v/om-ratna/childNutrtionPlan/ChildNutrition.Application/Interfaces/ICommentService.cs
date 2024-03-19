using ChildNutrition.Application.Models.Comments;

namespace ChildNutrition.Application.Interfaces
{
    public interface ICommentService
    {
        Task<int> CreateAsync(CreateCommentVM Comment, CancellationToken cancellationToken);
        
    }
}
