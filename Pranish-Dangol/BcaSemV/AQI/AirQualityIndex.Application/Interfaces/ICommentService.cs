using AirQualityIndex.Application.Models.Comment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirQualityIndex.Application.Interfaces
{
    public interface ICommentService
    {
        Task<int> CreateAsync (CreateCommentVM comment, CancellationToken cancellationToken);
    }
}
