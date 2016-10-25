using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkList
{
	class DLinkList<T> : Interface.IListDS<T>
	{
		private DNode<T> m_head;

		internal DNode<T> Head
		{
			get
			{
				return m_head;
			}

			set
			{
				m_head = value;
			}
		}

		public DLinkList()
		{
			m_head = new DNode<T>();
		}
		
		public DLinkList(DNode<T> i_head)
		{
			m_head = i_head;
		}

		public bool Append(T i_value)
		{
			throw new NotImplementedException();
		}

		public void Clearn()
		{
			throw new NotImplementedException();
		}

		public T Delete(int i_Inxdex)
		{
			throw new NotImplementedException();
		}

		public T GetElement(int i_Index)
		{
			throw new NotImplementedException();
		}

		public int GetLength()
		{
			throw new NotImplementedException();
		}

		public bool Insert(int i_Index, T i_value)
		{
			throw new NotImplementedException();
		}

		public bool IsEmpty()
		{
			throw new NotImplementedException();
		}

		public T Locate(T i_Value)
		{
			throw new NotImplementedException();
		}
	}
}
