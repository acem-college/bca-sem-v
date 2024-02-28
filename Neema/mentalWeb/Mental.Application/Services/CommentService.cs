using Mental.Application.Interfaces;
using Mental.Application.Models.Accounts;
using Mental.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Mental.Application.Services
{
    public class CommentService : ICommentService
    {
        private readonly IMentalDbContext _dbContext;
        public CommentService(IMentalDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> CreateAsync(CreateCommentVM comment, CancellationToken cancellationToken)
        {
            var dbComment = new Comment();
            dbComment.Name = comment.Name;
            dbComment.Email = comment.Email;
            dbComment.Message = comment.Message;
            dbComment.CreatedAt = DateTime.Now;
            _dbContext.Comments.Add(dbComment);

            await _dbContext.SaveChangesAsync(cancellationToken);
            return dbComment.Id;
        }
       

    }
}
