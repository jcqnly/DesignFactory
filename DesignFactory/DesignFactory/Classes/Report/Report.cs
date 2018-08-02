using System;
using System.Collections.Generic;
using System.Text;

namespace DesignFactory.Classes.Report
{
    public abstract class Report
    {
        public abstract string Name { get; set; }
        public abstract string Style { get; set; }
        public abstract int NumberOfSources { get; set; }
        public abstract int NumberOfPages { get; set; }
    }
}
