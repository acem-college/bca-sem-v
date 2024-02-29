using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bmi.Application.Interface;
using Bmi.Application.Models.Comment;
using Bmi.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Bmi.Application.Services
{
    public class CommentServices : ICommentServices
    {
        private readonly IBmiDbContext _dbcontext;
        public CommentServices(IBmiDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        

        public async Task<int> CreateAsync(CreateCommentVM comment, CancellationToken cancellationToken)
        {
            var dbComment = new Comment();
            dbComment.Name=comment.Name;
            dbComment.Email=comment.Email;
            dbComment.message=comment.Message;
            _dbcontext.Comments.Add(dbComment);

            await _dbcontext.SaveChangesAsync(cancellationToken);
            return dbComment.Id;


        }
    }
    
}
