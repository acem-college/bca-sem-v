using AirQualityIndex.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirQualityIndex.Application.Services
{
    public class ReportService : IReportService
    {
        private readonly IAqiDbContext _dbContext;
        public ReportService(IAqiDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
    }
}
