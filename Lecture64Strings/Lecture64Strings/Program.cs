using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture64Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Nichole Pellow ";
            Console.WriteLine("Trim example: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper example: '{0}'", fullName.Trim().ToUpper());
            Console.WriteLine("ToLower example: '{0}'", fullName.Trim().ToLower());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("First name: " + firstName);
            Console.WriteLine("Last name: " + lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("LastName: " + names[1]);

            Console.WriteLine(fullName.Replace("Nichole", "Niki Jo"));

            if (String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");

            var str = "25";
            var age = Convert.ToInt32(str);
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C"));
        }
    }
}
