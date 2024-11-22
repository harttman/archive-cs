using System;
namespace learn
{
    class Program
    {
        static void Main(string[] args)
        {
            SetUtf();
            int a = 5;
            int b = a + 10;
            Console.WriteLine(a + 5);
            Console.WriteLine(b + 5);
        }
        static void SetUtf()
        { 
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
        }
    }
}
