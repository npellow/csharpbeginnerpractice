using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //implicit type conversion
            /*byte b = 1;
            int i = b;
            Console.WriteLine(i);*/

            //explicit type conversion
            /*int i = 1;
            byte b = (byte)i;
            Console.WriteLine(b);*/

            //non-compatible type conversion
            /*string number = "1234";
            int i = Convert.ToInt32(number);
            Console.WriteLine(i);

            //using an exception with non-compatible type conversion
            try
            {
                string numbers = "1234";
                byte b = Convert.ToByte(numbers);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte.");
            }*/

            //using an exception with a string to bool conversion
            try
            {
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("The string could not be converted.");
            }
            

        }
    }
}
