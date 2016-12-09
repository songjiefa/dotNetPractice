using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
	class SequenceQueue<T> : IQueue<T>
	{
		private T[] m_data;
		private int m_front;
		private int m_rear;
		private int m_maxSize;

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

		public int Front
		{
			get
			{
				return m_front;
			}
		}

		public int Rear
		{
			get
			{
				return m_rear;
			}
		}

		public int MaxSize
		{
			get
			{
				return m_maxSize;
			}

			set
			{
				m_maxSize = value;
			}
		}

		public T this[int i_index]
		{
			get
			{
				return m_data[i_index];
			}
			set
			{
				m_data[i_index] = value;
			}
		}

		public SequenceQueue(int i_maxSize)
		{
			if(i_maxSize < 0)
			{
				Console.WriteLine("maxSize can not less than 0!");
				return;
			}
			m_data = new T[i_maxSize];
			m_front = -1;
			m_rear = 1;
			m_maxSize = i_maxSize;
		}

		public void Clear()
		{
			m_front = -1;
			m_rear = -1;
			m_data = null;
			m_maxSize = 0;
		}

		public T GetFront()
		{
			if(IsEmpty())
			{
				Console.WriteLine("Queue is empty!");
				return default(T);
			}

			return m_data[m_front];
		}

		public int GetLength()
		{
			if(m_front <0|| m_rear < 0)
			{
				return 0;
			}
			return m_rear - m_front + 1;
		}

		public void In(T i_item)
		{
			if (IsFull())
			{
				Console.WriteLine("Queue is full!");
				return;
			}
			m_rear++;
			m_data[m_rear] = i_item;
		}

		public bool IsEmpty()
		{
			return m_rear < 0 && m_front < 0;
		}

		public T Out()
		{
			if (IsEmpty())
			{
				Console.WriteLine("Queue is empty!");
				return default(T);
			}
			m_front++;
			return m_data[m_front];
		}

		private bool IsFull()
		{
			return m_rear >= m_maxSize;
		}
	}
}
