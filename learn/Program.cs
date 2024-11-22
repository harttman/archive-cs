using System;

namespace Program
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.InputEncoding = System.Text.Encoding.UTF8;

			string msg = "Тип {0,8} |\t.NET {1,8} |\tРозмір = {2} \t| MIN = {3,30}\t| MAX = {4}";

			Console.WriteLine("\n\t\t\t\t\tЧислові типи даних:\n");
			Console.WriteLine(string.Format(msg, "byte", typeof(byte).Name, sizeof(byte), byte.MinValue, byte.MaxValue));
            Console.WriteLine(string.Format(msg, "sbyte", typeof(sbyte).Name, sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue));
            Console.WriteLine(string.Format(msg, "short", typeof(short).Name, sizeof(short), short.MinValue, short.MaxValue));
            Console.WriteLine(string.Format(msg, "ushort", typeof(ushort).Name, sizeof(ushort), ushort.MinValue, ushort.MaxValue));
            Console.WriteLine(string.Format(msg, "int", typeof(int).Name, sizeof(int), int.MinValue, int.MaxValue));
            Console.WriteLine(string.Format(msg, "uint", typeof(uint).Name, sizeof(uint), uint.MinValue, uint.MaxValue));
            Console.WriteLine(string.Format(msg, "long", typeof(long).Name, sizeof(long), long.MinValue, long.MaxValue));
            Console.WriteLine(string.Format(msg, "ulong", typeof(ulong).Name, sizeof(ulong), ulong.MinValue, ulong.MaxValue));
        }
	}
}
