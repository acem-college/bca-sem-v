using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterQuality.Application.Interface
{
    public interface IWQDbContext
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
