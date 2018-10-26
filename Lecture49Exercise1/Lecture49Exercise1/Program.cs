using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture49Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 0;

            for (var i = 0; i <= 100; i++)
            {
                if (i % 3 == 0)
                    count++;
            }

            Console.WriteLine("There are {0} numbers divisble by 3 between 1 and 100.", count);
        }
    }
}
