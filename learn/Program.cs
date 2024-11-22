using System;
namespace learn
{
    class Program
    {
        static void Main(string[] args)
        {
            setUtf();
            int a;
            a = 5;
            Console.WriteLine(a);
        }
        static void setUtf()
        { 
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
        }
    }
}
