using Mental.Application.Models.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mental.Application.Interfaces
{
    public interface ICommentService
    {
        Task<int> CreateAsync(CreateCommentVM comment, CancellationToken cancellationToken);

    }
}
