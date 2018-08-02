using System;
using System.Collections.Generic;
using System.Text;

namespace DesignFactory.Classes
{
    public class DocStore
    {
        protected abstract Report CreateReport(string type);
    }
}
