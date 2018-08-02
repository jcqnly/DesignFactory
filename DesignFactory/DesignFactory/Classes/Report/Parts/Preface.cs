using System;
using System.Collections.Generic;
using System.Text;

namespace DesignFactory.Classes.Report.Parts
{
    public class Preface : Report
    {
        public override string Name { get; set; } = "The Beginnings";
        public override string Style { get; set; } = "Shakespearean";
        public override int NumberOfSources { get; set; } = 20;
        public override int NumberOfPages { get; set; } = 50;
    }
}
