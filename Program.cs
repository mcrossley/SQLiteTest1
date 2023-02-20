using System;

namespace SQLiteTest1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			SQLitePCL.Batteries_V2.Init();
			Console.WriteLine("Well that worked");
			Console.WriteLine("\npress any key to exit the process...");
			Console.ReadKey();
		}
	}
}
