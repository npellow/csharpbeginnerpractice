using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section5WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //for loop example for while loop
            /*for (var i = 1; i <= 10; i++)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }*/

            //while loop of above for loop example
            /*var i = 0;

            while (i <= 10)
            {
                if (i%2 == 0)
                    Console.WriteLine(i);

                i++;
            } */

            //while loop example
            while (true)
            {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();

                //keeps executing
                /*if (String.IsNullOrWhiteSpace(input))
                    break;

                Console.WriteLine("@Echo: " + input);*/

                //only executes once
                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine(input);
                    //add continue for it to keep executing instead of terminating after one execution
                    continue;
                }
                break;
            }
        }
    }
}
