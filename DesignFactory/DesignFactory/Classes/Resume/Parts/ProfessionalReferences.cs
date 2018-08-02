using System;
using System.Collections.Generic;
using System.Text;

namespace DesignFactory.Classes.Resume.Parts
{
    public class ProfessionalReferences : Resume
    {
        public override string JobType { get; set; } = "Science";
        public override string PersonName { get; set; } = "Billy Nye";
        public override bool Complete { get; set; } = true;
    }
}
