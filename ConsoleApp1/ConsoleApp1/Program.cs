using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person p = new Person()
            {
                Name = "luis",
                LastName = "nunez"
            };
            Student s = new Student()
            {
                Name = "luis",
                LastName = "nunez",
                Average = 9.5

            };
            Professor pr = new Professor()
            {
                Name = "luis",
                LastName = "nunez",
                Courses = new string[] {"das c3"}

            };
            printReport(p);
            printReport(s);
            printReport(pr);
            //Console.WriteLine(PrintReport(p));
            //Console.WriteLine(PrintReport(s));
            Console.ReadKey();

        }
        public static void printReport(Person person)
        {
            Console.WriteLine(person.GetSummary());
        }
        //public static string PrintReport(Person p)
        //{
        //    return p.Name + "" + p.LastName;
        //}
        //public static string PrintReport(Student s)
        //{
        //    return s.Name + "" + s.LastName+""+s.Average;
        //}
    }
}
