using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture43Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number between 1 and 10: ");

            var inputNum = Console.ReadLine();
            var number = Convert.ToInt32(inputNum);

            if (number >= 1 && number <= 10)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");
        }
    }
}
