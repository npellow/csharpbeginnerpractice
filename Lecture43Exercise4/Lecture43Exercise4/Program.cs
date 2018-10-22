using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture43Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the speed limit: ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.Write("How fast is the car going: ");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed < speedLimit)
            {
                Console.WriteLine("Good job staying under the speed limit.");
            }
            else
            {
                const int kmPerDemeritPoint = 5;
                var demeritPoints = (carSpeed - speedLimit) / kmPerDemeritPoint;

                if (demeritPoints > 12)
                {
                    Console.WriteLine("Oh no, you're going too fast! License now suspended!");
                }
                else
                {
                    Console.WriteLine("Slow it down. Demerit points: " + demeritPoints);
                }
            }
        }
    }
}
