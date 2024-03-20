using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterQuality.Domain.Entities;

namespace WaterQuality.Application.Interface
{
    public interface IReportService
    {
        List<Bagmati> GetReport();
    }
}
