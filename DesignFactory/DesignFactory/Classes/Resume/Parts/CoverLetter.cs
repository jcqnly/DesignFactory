using System;
using System.Collections.Generic;
using System.Text;

namespace DesignFactory.Classes.Resume.Parts
{
    public class CoverLetter : Resume
    {
        public override string JobType { get; set; } = "Engineering";
        public override string PersonName { get; set; } = "Neil DeGrasse Tyson";
        public override bool Complete { get; set; }
    }
}
