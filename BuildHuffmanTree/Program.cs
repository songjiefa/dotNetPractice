using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildHuffmanTree
{
	class Program
	{
		static void Main(string[] args)
		{
			HuffmanTree<int> hm = new HuffmanTree<int>(4);
			hm.Create();
		}
	}
}
