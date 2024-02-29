using Microsoft.AspNetCore.Mvc;
using WaterQuality.Application.Interface;

namespace WaterQualityMVC.ui.Controllers
{
    public class ReportsController: Controller
     
    {
        private readonly IReportService _reportService;
        public ReportsController(IReportService reportService)
        {
            _reportService = reportService;
        }
    }
}
