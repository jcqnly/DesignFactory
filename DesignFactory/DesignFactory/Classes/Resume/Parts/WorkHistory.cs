using System;
using System.Collections.Generic;
using System.Text;

namespace DesignFactory.Classes.Resume.Parts
{
    public class WorkHistory : Resume
    {
        public override string JobType { get; set; } = "Restaurant";
        public override string PersonName { get; set; } = "Wolfgang Puck";
        public override bool Complete { get; set; } = true;
    }
}
