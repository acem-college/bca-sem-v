using IrrigationInformationSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrrigationInformationSystem.Application.Interfaces
{
    public interface IIisDbContext
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        DbSet<Comment>Comments { get; set; }
    }
}
