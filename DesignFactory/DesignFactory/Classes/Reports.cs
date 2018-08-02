using System;
using System.Collections.Generic;
using System.Text;

namespace DesignFactory.Classes
{
    /// <summary>
    /// properties of the Reports class
    /// </summary>
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
