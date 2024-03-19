using ChildNutrition.Application.Interfaces;
using ChildNutrition.Application.Models.Comments;
using ChildNutrition.Domain.Entities;

namespace ChildNutrition.Application.Services
{
    public class CommentServices : ICommentService
    {
        private readonly IChildNutritionDbContext _dbcontext;
        public CommentServices(IChildNutritionDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public async Task<int> CreateAsync(CreateCommentVM Comment, CancellationToken cancellationToken)
        {
            var dbcomment = new Comment();
            dbcomment.Name = Comment.Name;
            dbcomment.Email = Comment.Email;
            dbcomment.Message = Comment.Message;
            dbcomment.CreatedAt = DateTime.Now;
            _dbcontext.Comments.Add(dbcomment);

            await _dbcontext.SaveChangesAsync(cancellationToken);
            return dbcomment.Id;
        }

    }

}
