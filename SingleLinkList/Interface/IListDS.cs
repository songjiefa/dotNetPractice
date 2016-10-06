using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkList.Interface
{
	interface IListDS<T>
	{
		int GetLength();
		bool IsEmpty();
		void Clear();
		void Append(T i_Item);
		void Insert(T i_Item, int i_Index);
		T Delete(int i_Index);
		T GetElement(int i_Index);
		int Locate(T i_Value);
	}
}
