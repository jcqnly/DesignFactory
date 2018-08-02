using System;
using System.Collections.Generic;
using System.Text;

namespace DesignFactory.Classes.Report.Parts
{
    public class Conclusion : Report
    {
        public override string Name { get; set; } = "The End";
        public override string Style { get; set; } = "Romantic";
        public override int NumberOfSources { get; set; } = 2;
        public override int NumberOfPages { get; set; } = 30;
    }
}
