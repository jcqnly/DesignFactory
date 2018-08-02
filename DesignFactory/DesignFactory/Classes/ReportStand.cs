using System;
using System.Collections.Generic;
using System.Text;

namespace DesignFactory.Classes
{
    class ReportStand : ReportStore
    {
        protected override Reports CreateReports(string type)
        {
            Console.WriteLine("Creating the report");
            return ReportFactory.CreateReports(type);
        }
    }
}
