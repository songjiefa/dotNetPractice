using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
	class Program
	{
		static void Main(string[] args)
		{
			SeqStack<int> ss = new SeqStack<int>(900);

			ss.Push(2);
			ss.Push(3);
			ss.Push(42);
			ss.Push(25);
			ss.Push(24);
			ss.Push(25);
			ss.Push(23);
			ss.Push(72);
			ss.Push(235);
			ss.Push(43);

			while(ss.Top >= 0)
			{
				Console.WriteLine(ss.Pop());
			}

			Console.ReadKey();
		}
	}
}
