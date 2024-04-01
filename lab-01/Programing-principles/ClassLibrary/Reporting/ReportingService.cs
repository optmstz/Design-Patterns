using ClassLibrary.WarehousePart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.ReportingPart.Reporters;

namespace ClassLibrary.ReportingPart
{
    public class ReportingService
    {
        private readonly Warehouse _warehouse;

        public ReportingService(Warehouse warehouse)
        {
            _warehouse = warehouse;
        }

        public void RegisterReport(IReporter reporter)
        {
            reporter.Report();
        }
    }
}
