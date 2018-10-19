using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionFourStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Nichole";
            var lastName = "Pellow";

            //using concat to combine strings
            var myName = firstName + " " + lastName;
            //using .format to combine strings
            var myFullName = string.Format("My name is {0} {1}.", firstName, lastName);

            //array of names
            var names = new string[3] { "Elsie", "John Avery", "Mae" };
            var formattedNames = string.Join(", ", names);
            //Console.WriteLine(formattedNames);

            //verbatim strings
            //var text = "Hi John\nLook into the following paths\nc:\\folder1\\folder2\nc:\\folder3\\folder4";
            //clean it up using verbatim
            var text = @"Hi John
Look into the following paths
c:\folder1\folder2
c:\folder3\folder4";
            Console.WriteLine(text);
        }
    }
}
