using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture65SummarisingText
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is going to be a really really really really really super duper long text.";
            var summary = StringUtility.SummerizeText(sentence, 25);
            Console.WriteLine(summary);
        }

    }
}
