using IrrigationInformationSystem.Application.Interfaces;

namespace IrrigationInformationSystem.Application.Services
{
    public class ReportService : IReportService
    {
        private readonly IIisDbContext _dbContext;
        public ReportService(IIisDbContext dbContext)
        {
            _dbContext = dbContext;
        }


    }
}
