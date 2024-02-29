using Pim.Application.Interfaces;
using Pim.Application.Models.Comment;
using Pim.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pim.Application.Services
{
    public class CommentServices : ICommentServices
    {
        private readonly IPimDbContext _dbContext; 
        public CommentServices(IPimDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<int> CreateAsync(CreateCommentVm Comment, CancellationToken cancellationToken)
        {
            var dbComment = new Comment();
            dbComment.Name = Comment.Name;
            dbComment.Email = Comment.Email;
            dbComment.Message = Comment.Message;
            _dbContext.Comments.Add(dbComment);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return dbComment.Id;
        }
    }
}
