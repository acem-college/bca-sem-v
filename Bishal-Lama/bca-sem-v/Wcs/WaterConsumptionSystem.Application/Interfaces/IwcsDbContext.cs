using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterConsumptionSystem.Application.Interfaces
{
    public interface IwcsDbContext
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
