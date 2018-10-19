using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section4Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            //array using int; shows that if nothing is added the default int is 0
            var numbers = new int[3];
            numbers[0] = 1;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            //array using booleans; shows that if nothing is added the default is false
            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            //array using strings; shows better way of doing it
            var names = new string[3] { "Jack", "John", "Mary" };
        }
    }
}
