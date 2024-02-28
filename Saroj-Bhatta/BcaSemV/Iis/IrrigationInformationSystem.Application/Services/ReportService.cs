using IrrigationInformationSystem.Application.Interfaces;
<<<<<<< HEAD
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrrigationInformationSystem.Application.Services
{
    public class ReportService:IReportService
=======

namespace IrrigationInformationSystem.Application.Services
{
    public class ReportService : IReportService
>>>>>>> a87f4f70fe29f9fc5fba85573f185ee3917da05f
    {
        private readonly IIisDbContext _dbContext;
        public ReportService(IIisDbContext dbContext)
        {
            _dbContext = dbContext;
        }
<<<<<<< HEAD
=======


>>>>>>> a87f4f70fe29f9fc5fba85573f185ee3917da05f
    }
}
