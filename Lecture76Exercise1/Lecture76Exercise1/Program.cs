using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lecture76Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\sampleFolder\test.txt";
            var content = File.ReadAllText(path);

            var words = content.Split(new char[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("Number of words in file: " + words.Length);
        }
    }
}
