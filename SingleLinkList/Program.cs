﻿using System;
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
			var LinkList1 = LinkList<String>.CreateLinkList();

			LinkList1.ReversLinkList();
			
			LinkList<String>.PrintLinkList(LinkList1);

			Console.ReadKey();
		}
	}
}
