using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Student:Person
    {
        public double Average { get; set; }

        public override string GetSummary()
        {
            return base.GetSummary() + ", AVG: " + Average;
        }
    }
  
}
