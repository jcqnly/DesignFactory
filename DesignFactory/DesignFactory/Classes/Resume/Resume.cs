using System;
using System.Collections.Generic;
using System.Text;

namespace DesignFactory.Classes.Resume
{
    public abstract class Resume
    {
        public abstract string JobType { get; set; }
        public abstract string PersonName { get; set; }
        public abstract bool Complete { get; set; }
    }
}
