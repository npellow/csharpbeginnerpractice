using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture68Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a few numbers separated by a hyphen (eg. 1-2-3-4 or 9-2-12-7-11): ");
            var input = Console.ReadLine();

            var numbers = new List<int>();
            foreach (var number in input.Split('-'))
                numbers.Add(Convert.ToInt32(number));

            numbers.Sort();

            var isConsecutive = true;
            for (var i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] != numbers[i - 1] + 1)
                {
                    isConsecutive = false;
                    break;
                }
            }

            var message = isConsecutive ? "Consecutive" : "Not consecutive";
            Console.WriteLine(message);
        }
    }
}
