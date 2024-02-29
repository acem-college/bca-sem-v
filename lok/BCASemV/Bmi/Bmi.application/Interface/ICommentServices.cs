using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bmi.Application.Models.Comment;

namespace Bmi.Application.Interface
{
   public interface ICommentServices
    {

        Task<int>CreateAsync(CreateCommentVM comment, CancellationToken cancellationToken); 
    }
}
