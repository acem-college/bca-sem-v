using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterQuality.Application.Models.Comment;

namespace WaterQuality.Application.Interface
{
    public interface ICommentService
    {
        Task<int> CreateAsync(CreateCommentVm comment, CancellationToken cancellationToken);
    }
}
