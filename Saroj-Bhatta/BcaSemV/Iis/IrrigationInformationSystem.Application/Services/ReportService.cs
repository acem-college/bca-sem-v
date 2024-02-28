using IrrigationInformationSystem.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrrigationInformationSystem.Application.Services
{
    public class ReportService:IReportService
    {
        private readonly IIisDbContext _dbContext;
        public ReportService(IIisDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
