using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
	public class SeqStack<T> : Interface.IStack<T>
	{
		private int m_maxsize;
		private T[] m_data;
		private int m_top;

		public int Maxsize
		{
			get
			{
				return m_maxsize;
			}

			set
			{
				m_maxsize = value;
			}
		}

		public T[] Data
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

		public int Top
		{
			get
			{
				return m_top;
			}
		}

		public T this[int i_index]
		{
			get
			{
				return Data[i_index];
			}
			set
			{
				Data[i_index] = value;
			}
		}

		public SeqStack(int i_size)
		{
			if (i_size < 0)
			{
				Console.WriteLine("size can not less than zero!");
				return;
			}
			m_data = new T[i_size];
			m_maxsize = i_size;
			m_top = -1;
		}

		public void Clear()
		{
			m_data = null;
			m_maxsize = -1;
			m_top = -1;
		}

		public int GetLength()
		{
			return m_top + 1;
		}

		public T GetTop()
		{
			if(m_top < 0)
			{
				Console.WriteLine("stack is empty!");
				return default(T);
			}
			return m_data[m_top];
		}

		public bool IsEmpty()
		{
			return m_top < 0;
		}

		public T Pop()
		{
			if(m_top < 0)
			{
				Console.WriteLine("stack is empty!");
				return default(T);
			}

			var result = m_data[m_top];
			m_data[m_top] = default(T);
			m_top--;
			return result;
		}

		public void Push(T i_item)
		{
			if (m_top >= m_maxsize)
			{
				Console.WriteLine("stack overflow!");
				return;
			}

			m_top++;
			m_data[m_top] = i_item;
		}
	}
}
