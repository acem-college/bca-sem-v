using IrrigationInformationSystem.Application.Models.Comment;
using IrrigationInformationSystem.Application.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrrigationInformationSystem.Application.Interfaces
{
    public interface ICommentService
    {
        Task<int>CreateAsync(CreateCommentVM comment,CancellationToken cancellationToken);
    }
}
