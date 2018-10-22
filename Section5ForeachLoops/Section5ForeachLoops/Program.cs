using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section5ForeachLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            /* var name = "John Smith";

            //for loop example to be simplified after with a foreach loop
            for (var i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            Console.WriteLine("\b");

            //simplified foreach loop
            foreach (var character in name)
            {
                Console.WriteLine(character);
            } */

            //foreach with an array
            var numbers = new int[] { 1, 2, 3, 4 };

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
