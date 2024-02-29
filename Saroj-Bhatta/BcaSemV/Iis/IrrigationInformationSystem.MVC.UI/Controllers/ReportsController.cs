using IrrigationInformationSystem.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IrrigationInformationSystem.MVC.UI.Controllers
{
    [Authorize]
<<<<<<< HEAD
    public class ReportsController : Controller
=======
    public class ReportsController : ControllerBase
>>>>>>> a87f4f70fe29f9fc5fba85573f185ee3917da05f
    {
        private readonly IReportService _reportService;
        public ReportsController(IReportService reportService)
        {
            _reportService = reportService;
        }
<<<<<<< HEAD
    }
}
=======

        // Charts - GoogleChart, ChartJS
    }
}
>>>>>>> a87f4f70fe29f9fc5fba85573f185ee3917da05f
