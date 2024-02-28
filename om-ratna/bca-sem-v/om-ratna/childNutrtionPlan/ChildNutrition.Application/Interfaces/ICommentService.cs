using ChildNutrition.Application.Models.Comments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildNutrition.Application.Interfaces
{
    public interface ICommentService
    {
        Task<int> CreateAsync(CreateCommentVM Comment, CancellationToken cancellationToken);
        
    }
}
