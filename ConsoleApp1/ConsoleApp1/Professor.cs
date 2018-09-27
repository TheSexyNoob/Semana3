using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Professor:Person
    {
        public string[] Courses { get; set; }
        public override string GetSummary()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.GetSummary());
            for (int i = 0; i < Courses.Length; i++)
            {
                sb.AppendLine(Courses[i]);
            }
            return sb.ToString();
        }
    }
}
