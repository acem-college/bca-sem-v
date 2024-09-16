using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using WaterConsumptionSystem.Application.Interfaces;
using WaterConsumptionSystem.Application.Models.Comment;
using WaterConsumptionSystem.Domain.Entities;

namespace WaterConsumptionSystem.Application.Services
{
    public class CommentService : ICommentService
    {
        private readonly IwcsDbContext _dbContext;
        public  CommentService(IwcsDbContext iwcsDbContext)
        {
            _dbContext = iwcsDbContext;
        }
        public async Task<int>CreateAsync(CreateCommentVM comment, CancellationToken cancellationToken)
        {
            var dbComment = new Comment();
            dbComment.Name = comment.Name;
            dbComment.Email = comment.Email;
            dbComment.CreatedAt=DateTime.Now;
            _dbContext.Comments.Add(dbComment);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return dbComment.Id;
        }
        
    }
}
