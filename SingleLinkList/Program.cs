using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkList
{
	class Program
	{
		static void Main(string[] args)
		{
			var link = CreateLinkList();
		}

		static LinkList<String> CreateLinkList()
		{
			var result = new LinkList<String>();
			var input = Console.ReadLine();

			result.Head = new Node<String>();
			var position = result.Head;

			while(input != "qq")
			{
				position.Next = new Node<String>(input);
				position = position.Next;
				input = Console.ReadLine();
			}
			return result;
		}
	}
}
