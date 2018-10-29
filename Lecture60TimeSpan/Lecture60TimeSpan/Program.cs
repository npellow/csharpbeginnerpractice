using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture60TimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            //examples of how to use TimeSpan

            // Creating TimeSpan object
            var timeSpan = new TimeSpan(1, 2, 3);

            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration: " + duration);

            // Properties
            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);

            // Add & Subtract
            Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Subtract Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            // ToString
            Console.WriteLine("ToString Example: " + timeSpan.ToString());

            // Parse for ToString
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));
        
        }
    }
}
