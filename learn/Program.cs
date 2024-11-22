using System;
namespace learn
{
    class Program
    {
        static void Main(string[] args)
        {
            SetUtf();
            /*
             * bool variable = false;
             * bool variable = true;
             * ERROR: CS0128 - A local variable named 'variable' is already defined in this scope
             */
            // best:

            bool notTrue = false;
            bool notFalse = false;
            Console.WriteLine(notFalse);
            Console.WriteLine(notTrue);
        }
        static void SetUtf()
        { 
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
        }
    }
}
