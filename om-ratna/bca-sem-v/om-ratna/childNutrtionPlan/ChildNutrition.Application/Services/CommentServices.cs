using ChildNutrition.Application.Interfaces;
using ChildNutrition.Application.Models.Comments;
using ChildNutrition.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            dbcomment.CreatedAt = DateTime.Now;
            _dbcontext.Comments.Add(dbcomment);

            await _dbcontext.SaveChangesAsync(cancellationToken);
            return dbcomment.Id;
        }

    }

}
