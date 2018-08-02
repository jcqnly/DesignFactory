using System;
using System.Collections.Generic;
using System.Text;

namespace DesignFactory.Classes.Report.Parts
{
    public class Bibliography : Report
    {
        public override string Name { get; set; } = "The Milky Way";
        public override string Style { get; set; } = "Chicago Manual";
        public override int NumberOfSources { get; set; } = 200;
        public override int NumberOfPages { get; set; } = 10;
    }
}
