using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterQuality.Application.Interface;
using WaterQuality.Application.Models.Comment;
using WaterQuality.Domain.Entities;

namespace WaterQuality.Application.Services
{
    public class CommentService: ICommentService
    {
        private readonly IWQDbContext _dbContext;
        public CommentService(IWQDbContext wQDbContext)
        {
            _dbContext = wQDbContext;
        }
        public async Task<int>CreateAsync(CreateCommentVm comment, CancellationToken cancellationToken)
        {
            var dbComment = new Comment();
            dbComment.Name = comment.Name;
            dbComment.Email = comment.Email;
            dbComment.Message = comment.Message;
            dbComment.CreatedAt= DateTime.Now;
            _dbContext.Comments.Add(dbComment);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return dbComment.Id;
        }
       
    }
}
