using AirQualityIndex.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirQualityIndex.Application.Interfaces
{
    public interface IAqiDbContext
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        DbSet<Comment> Comments { get; set; }
    }
}
