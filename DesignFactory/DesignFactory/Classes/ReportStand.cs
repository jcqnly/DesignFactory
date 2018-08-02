using System;
using System.Collections.Generic;
using System.Text;

namespace DesignFactory.Classes
{
    /// <summary>
    /// Inherits ReportStore properties
    /// </summary>
    class ReportStand : ReportStore
    {
        protected override Reports CreateReports(string type)
        {
            Console.WriteLine($"Creating the {type} report");
            return ReportFactory.CreateReports(type);
        }
    }
}
