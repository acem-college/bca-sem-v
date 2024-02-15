using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mental.Application.Interfaces
{
    public interface IMentalDbContext
    {


        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
