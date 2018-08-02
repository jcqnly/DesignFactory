using System;
using System.Collections.Generic;
using System.Text;

namespace DesignFactory.Classes
{
    class ReportFactory
    {
        /// <summary>
        /// Concrete object of the Creator
        /// </summary>
        /// <param name="reportType"></param>
        /// <returns>type Report</returns>
        public static Reports CreateReports(string reportType)
        {
            Console.WriteLine($"Writing a {reportType} report");
            Reports reports = null;
            switch (reportType.ToLower())
            {
                case "news":
                    reports = new News();
                    break;

                case "science":
                    reports = new Science();
                    break;

                default:
                    break;
            }
            return reports;
        }
    }
}
