using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
	class Program
	{
		static void Main(string[] args)
		{
			Int64 a = 100, b = 100;
			Console.WriteLine(a == b);
			Int64 c = 1000, d = 1000;
			Console.WriteLine(c == d);
			

			for(int i = 10, j = 1; 
				j > 0 && i > 0; 
				i++, j--)
			{
				Console.WriteLine("_");
			}
			Console.ReadKey();
		}
	}
}
