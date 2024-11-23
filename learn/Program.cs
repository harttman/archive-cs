using System;

/*
 * Convert types
 */

namespace learn
{
    class Program
    {
        static void Main(string[] args)
        {
            SetUtf();
            /*
             * string ageStr = "16";
             * int ageInt = Convert.ToInt32(ageStr); 
             * value in age int : 16
             */
            int number_one, number_two;
            int result;
            Console.WriteLine("----------");
            Console.Write("Введіть перше число: ");
            number_one = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("----------");
            Console.Write("Введіть друге число: ");
            number_two = Convert.ToInt32(Console.ReadLine());
            result = number_two + number_one;

            Console.WriteLine("----------");
            Console.WriteLine("Перше число\t" + number_one + "| Друге число\t" + number_two+"| Результат\t"+result);
        }
        static void SetUtf()
        { 
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
        }
    }
}
