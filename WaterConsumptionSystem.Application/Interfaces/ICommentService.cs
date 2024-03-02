using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterConsumptionSystem.Application.Models.Comment;

namespace WaterConsumptionSystem.Application.Interfaces
{
    public interface ICommentService
    {
        Task<int> CreateAsync(CreateCommentVM comment, CancellationToken cancellationToken);
    }
}
