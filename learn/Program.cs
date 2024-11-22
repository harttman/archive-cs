using System;

namespace Program
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.InputEncoding = System.Text.Encoding.UTF8;

			Console.WriteLine("\t\t\t\tЧислові Типи\n");
			Console.WriteLine("Тип\tByte\t|\t.NET\tBYTE\t|\tРозір = 1\t0\t|\tMAX = 255");
			Console.WriteLine("Тип\tsByte\t|\t.NET\tBYTE\t|\tРозмір = 1\t-128\t|\tMAX = 127");
			Console.WriteLine("Тип\tshort\t|\t.NET\tInt16\t|\tРозмір = 2\t-3276\t|\tMAX = 37267");
			Console.WriteLine("Тип\tushort\t|\t.NET\tUInt16\t|\tРозмір = 2\t0\t|\tMAX = 65535");
		}
	}
}
