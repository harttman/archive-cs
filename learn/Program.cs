using System;

namespace learn
{
    class Program
    {
        static void Main(string[] args)
        {
            SetUtf();
            /*
             * double number = 1.33;
             * Console.WriteLine(number);
            */

            /*
             * char hello = 'привіт'
             * Error: C1012
             * Best:
             */
            char hello = 'h';
            string helloOnUkr = "привіт";
            Console.WriteLine(hello + " " + helloOnUkr);
        }
        static void SetUtf()
        { 
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
        }
    }
}
