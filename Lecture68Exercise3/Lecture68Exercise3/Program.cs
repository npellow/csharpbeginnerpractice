using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture68Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a time in 24 hour format (e.g. 12:34): ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            var components = input.Split(':');
            if (components.Length != 2)
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            try
            {
                var hour = Convert.ToInt32(components[0]);
                var minute = Convert.ToInt32(components[1]);

                if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
                    Console.WriteLine("ok");
                else
                    Console.WriteLine("Invalid time");
            }
            catch
            {
                Console.WriteLine("Invalid time");
            }
        }
    }
}
