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

		public void Append(T i_value)
		{
			if(m_head == null)
			{
				m_head = new DNode<T>();
				m_head.Next = new DNode<T>(i_value);
				m_head.Next.Previous = m_head;

				return;
			}
			var pointNode = m_head.Next;
			var prePoint = m_head;

			while (pointNode != null)
			{
				prePoint = pointNode;
				pointNode = pointNode.Next;
			}

			pointNode = new DNode<T>(i_value);
			pointNode.Previous = prePoint;
			pointNode.Next = null;
		}

		public void Clearn()
		{
			m_head = null;
		}

		public T Delete(int i_Index)
		{

			if (m_head == null || m_head.Next == null || i_Index < 0)
			{
				Console.WriteLine("Link is empty or position is error!");
				return default(T);
			}
			var index = 0;
			var point = m_head;
			while(index < i_Index)
			{
				if(point == null)
				{
					Console.WriteLine("Index is overflow");
					return default(T);
				}

				index++;
				point = point.Next;
			}

			point.Previous.Next = point.Next;
			point.Next.Previous = point.Previous;

			return point.Data;
		}

		public T GetElement(int i_Index)
		{

			if (m_head == null || m_head.Next == null || i_Index < 0)
			{
				Console.WriteLine("Link is empty or position is error!");
				return default(T);
			}

			var index = 0;
			var point = m_head;

			while(index < i_Index)
			{
				if (point == null)
				{
					Console.WriteLine("Index is overflow");
					return default(T);
				}

				index++;
				point = point.Next;
			}

			return point.Data;
		}

		public int GetLength()
		{
			if (m_head == null || m_head.Next == null)
			{
				Console.WriteLine("Link is empty or position is error!");
				return 0;
			}

			var length =0;

			var point = m_head;

			while(point.Next != null)
			{
				length++;
			}

			return length;
		}

		public bool Insert(int i_Index, T i_value)
		{
			if (m_head == null || m_head.Next == null || i_Index < 0)
			{
				Console.WriteLine("Link is empty or position is error!");
				return false;
			}

			var index = 0;
			var point = m_head;

			while(index < i_Index)
			{
				if (point == null)
				{
					Console.WriteLine("Index is overflow");
					return false;
				}

				index++;
				point = point.Next;
			}

			var insertNode = new DNode<T>(i_value);
			point.Next.Previous = insertNode;
			insertNode.Next = point.Next;
			point.Next = insertNode;
			insertNode.Previous = point;

			return true;
		}

		public bool IsEmpty()
		{
			if(m_head == null || m_head.Next == null)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public Int32 Locate(T i_Value)
		{
			if (m_head == null || m_head.Next == null )
			{
				Console.WriteLine("Link is empty or position is error!");
				return -1;
			}

			var point = m_head;
			var index = 0;

			while(point != null)
			{
				if(point.Data.Equals(i_Value))
				{
					return index;
				}

				index++;
				point = point.Next;
			}

			return -1;
		}
	}
}
