using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkList
{
	class DNode<T>
	{
		private T m_data;
		private DNode<T> m_previous;
		private DNode<T> m_next;

		public T Data
		{
			get
			{
				return m_data;
			}

			set
			{
				m_data = value;
			}
		}

		internal DNode<T> Previous
		{
			get
			{
				return m_previous;
			}

			set
			{
				m_previous = value;
			}
		}

		internal DNode<T> Next
		{
			get
			{
				return m_next;
			}

			set
			{
				m_next = value;
			}
		}

		public DNode()
		{
			m_data = default(T);
			
			m_next = null;
		}

		public DNode(T i_value)
		{
			m_data = i_value;
			
			m_next = null;
		}

		public DNode(DNode<T> i_previous, DNode<T> i_next)
		{
			m_previous = i_previous;
			m_next = i_next;
		}

		public DNode(T i_value,DNode<T> i_previous,DNode<T> i_next)
		{
			m_data = i_value;
			m_previous = i_previous;
			m_next = i_next;
		}
	}
}
