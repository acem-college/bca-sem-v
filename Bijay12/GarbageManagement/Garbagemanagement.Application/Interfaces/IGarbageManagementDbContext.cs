using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garbagemanagement.Application.Interfaces
{
    public interface IGarbageManagementDbContext
    {
        Task<int>saveChangesAsync(CancellationToken cancellationToken);
    }
}
