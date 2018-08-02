using System;
using System.Collections.Generic;
using System.Text;

namespace DesignFactory.Classes
{
    public abstract class Reports
    {
        public void Research()
        {
            Console.WriteLine("Researching for the report");
        }

        public void Write()
        {
            Console.WriteLine("Writing the report");
        }

        public void TurnIn()
        {
            Console.WriteLine("Turning in the report");
        }
    }
}
