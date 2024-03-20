using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterQuality.Domain.Entities;

namespace WaterQuality.Application.Interface
{
    public interface IWQDbContext
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        DbSet<Comment>Comments { get; set; }
        DbSet<Bagmati> Bagmati{ get; set; }
    }
}
