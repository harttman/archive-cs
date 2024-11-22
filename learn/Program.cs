using System;

namespace learn
{
    class Program
    {
        static void Main(string[] args)
        {
            SetUtf();
            string data;

            data = Console.ReadLine();

            Console.WriteLine("You typed: " + data);
        }
        static void SetUtf()
        { 
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
        }
    }
}
