using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterQuality.Application.Interface;
using WaterQuality.Domain.Entities;

namespace WaterQuality.Application.Services
{
    public class ReportService:IReportService
    {
        private readonly IWQDbContext _dbContext;
        public ReportService(IWQDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Bagmati> GetReport()
        {
            var response=_dbContext.Bagmati.ToList();
            return response;
        }
    }
}
