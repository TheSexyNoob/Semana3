using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        public   virtual string GetSummary()
        {
            return string.Format("{0}{1}", Name, LastName);
        }
        //public string GetName(string value)
        //{
        //    return value;
        //}
        //public static string GetStaticName(string vale)
        //{
        //    return vale;
        //}
    }
}
