using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture49Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            while (true)
            {
                Console.Write("Enter a number, or 'ok' to exit: ");
                var input = Console.ReadLine();

                if (input.ToLower() == "ok")
                    break;

                sum += Convert.ToInt32(input);
            }

            Console.WriteLine("The sum of all numbers is: " + sum);
        }
    }
}
