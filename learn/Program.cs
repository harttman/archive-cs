using System;
using System.Globalization;

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
            string name;
            int age = 0;
            bool isStudent = false;
            Console.WriteLine("Введите своё имя");
            name = Console.ReadLine();
            Console.WriteLine("Введите свой возраст");
            try
            {
                age = int.Parse(Console.ReadLine());
                Console.WriteLine("Успешная конвертация.");
            } catch (Exception)
            {
                Console.WriteLine("Чето пошло не так! Введете другие данные.");
            }
            Console.WriteLine("Вы студент? true/false");
            try
            {
                isStudent = bool.Parse(Console.ReadLine());
                Console.WriteLine("Успешная конвертация");
            } catch (Exception)
            {
                Console.WriteLine("Надо ввести, либо true либо false.");
            }


            Console.WriteLine("\n----------------------\nИмя: " + name + "\nВозраст: " + age + "\nСтудент?: "+isStudent);
        }
        static void SetUtf()
        { 
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
        }
    }
}
