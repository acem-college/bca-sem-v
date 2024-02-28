using AirQualityIndex.Application.Interfaces;
using AirQualityIndex.Application.Models.Comment;
using AirQualityIndex.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirQualityIndex.Application.Services
{
    public class CommentService : ICommentService
    {
        private readonly IAqiDbContext _dbcontext;
        public CommentService(IAqiDbContext aqiDbContext)
        {
            _dbcontext = aqiDbContext;
        }
        public async Task<int> CreateAsync(CreateCommentVM comment, CancellationToken cancellationToken)
        {
            var dbComment = new Comment();
            dbComment.Name = comment.Name;
            dbComment.Email = comment.Email;
            dbComment.Message = comment.Message;
            dbComment.CreatedAt= DateTime.Now;
            _dbcontext.Comments.Add(dbComment);
            await _dbcontext.SaveChangesAsync(cancellationToken);
            return dbComment.Id;
        }
    }
}
