using System;
using System.Collections.Generic;
using System.Text;

namespace DesignFactory.Classes
{
    /// <summary>
    /// Creation of the report.  This will be implemented in ReportStand.cs
    /// </summary>
    public abstract class ReportStore
    {
        protected abstract Reports CreateReports(string type);

        public Reports OrderReport(string type)
        {
            Reports reports = CreateReports(type);

            reports.Research();
            reports.Write();
            reports.TurnIn();

            return reports;
        }
    }
}
