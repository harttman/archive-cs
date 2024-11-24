using System;

/*
 * Parse String 
 */

namespace learn
{
    class Program
    {
        static void Main(string[] args)
        {
            SetUtf();
            string data = ""; // default value: empty string
            int pastringData; // no value

            data = Console.ReadLine();
            
            bool result = int.TryParse(data, out pastringData); // TRY parse to int and get result (bool)
            if(result)
            {
                Console.WriteLine("Success parse");
            } else
            {
                Console.WriteLine("Error parse... type new data! Only number");
                return; // if result false out program
            }

            // if run else block, this not work.
            Console.WriteLine(data + pastringData); // out console

        }
        static void SetUtf()
        { 
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
        }
    }
}
