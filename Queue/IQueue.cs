﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
	public interface IQueue<T>
	{
		int GetLength();
		bool IsEmpty();
		void Clear();
		void In(T i_item);
		T Out();
		T GetFront();
	}
}
