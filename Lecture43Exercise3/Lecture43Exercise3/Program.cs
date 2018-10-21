using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture43Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Find a picture... What is the length: ");
            var length = Convert.ToInt64(Console.ReadLine());

            Console.Write("Now enter the width: ");
            var width = Convert.ToInt64(Console.ReadLine());

            if (length > width)
                Console.WriteLine("This is a portrait");
            else
                Console.WriteLine("This is a landscape");
        }
    }
}
