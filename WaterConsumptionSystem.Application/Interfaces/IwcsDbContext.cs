using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterConsumptionSystem.Domain.Entities;

namespace WaterConsumptionSystem.Application.Interfaces
{
    public interface IwcsDbContext
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        DbSet<Comment> Comments { get; set; }
    }
}
