using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.Interface
{
	public interface IStack<T>
	{
		int GetLength();
		bool IsEmpty();
		void Clear();
		void Push(T i_item);
		T Pop();
	}
}
