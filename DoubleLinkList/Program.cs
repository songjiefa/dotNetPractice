using DoubleLinkList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkList
{
	class Program
	{
		static void Main(string[] args)
		{
			DLinkList<int> dl = new DLinkList<int>();

			dl.Append(1);
			dl.Append(5);
			dl.Append(6);

			dl.Append(7);
			dl.Insert(0, 2);

			var get = dl.GetElement(1);

			Console.WriteLine(dl.GetLength());
			Console.WriteLine(get);
			Console.ReadKey();
		}
	}
}
