using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkList.Interface
{
	interface IListDS<T>
	{
		int GetLength();

		void Clearn();

		bool IsEmpty();

		void Append(T i_value);

		bool Insert(int i_Index, T i_value);

		T Delete(int i_Index);

		int Locate(T i_Value);

		T GetElement(int i_Index);
	}
}
