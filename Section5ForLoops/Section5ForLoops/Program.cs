using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section5ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 1; i <= 10; i++)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            for (var j = 10; j >= 1; j--)
            {
                if (j%2 == 0)
                {
                    Console.WriteLine(j);
                }
            }
        }
    }
}
