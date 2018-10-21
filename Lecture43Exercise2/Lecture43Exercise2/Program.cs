using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture43Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            var a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another number: ");
            var b = Convert.ToInt32(Console.ReadLine());

            var max = (a > b) ? a : b;
            Console.WriteLine("The max number is: " + max);
        }
    }
}
