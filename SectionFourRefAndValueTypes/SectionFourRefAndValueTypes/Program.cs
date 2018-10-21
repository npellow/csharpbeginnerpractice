using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionFourRefAndValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //simple example of value types in action
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a: {0} b: {1}", a, b));

            //simple example of reference types in action
            var array1 = new int[3] {1, 2 , 3};
            var array2 = array1;
            array2[0] = 0;
            Console.WriteLine(string.Format("array1[0]: {0} array2[0]: {1}", array1[0], array2[0]));
        }
    }
}
