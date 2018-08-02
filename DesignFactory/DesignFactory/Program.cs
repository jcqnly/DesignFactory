using DesignFactory.Classes;
using System;

namespace DesignFactory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Reports();
            Console.ReadLine();
        }

        public static void Reports()
        {
            Reports reports = null;
            ReportStand reportStand = new ReportStand();
            reports = ReportFactory.CreateReports("news");
        }
    }
}
