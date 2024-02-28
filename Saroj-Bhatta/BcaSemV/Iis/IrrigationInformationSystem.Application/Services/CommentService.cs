using IrrigationInformationSystem.Application.Interfaces;
using IrrigationInformationSystem.Application.Models.Comment;
using IrrigationInformationSystem.Domain.Entities;

namespace IrrigationInformationSystem.Application.Services
{
    public class CommentService : ICommentService
    {
        private readonly IIisDbContext _dbContext;
        public CommentService(IIisDbContext iisDbContext)
        {
            _dbContext = iisDbContext;
        }
        public  async Task<int> CreateAsync(CreateCommentVM comment, CancellationToken cancellationToken)
        {
            var dbcomment = new Comment();
            dbcomment.Name = comment.Name;
            dbcomment.Email = comment.Email;
            dbcomment.Message = comment.Message;
            dbcomment.CreatedAt = DateTime.Now;
            _dbContext.Comments.Add(dbcomment);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return dbcomment.Id;
        }
    }
}
