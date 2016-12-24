using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildHuffmanTree
{
	class HuffmanTree<T>
	{
		private Node<T>[] m_data;
		private int m_leafNumber;

		internal Node<T>[] Data
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

		public int LeafNumber
		{
			get
			{
				return m_leafNumber;
			}

			set
			{
				m_leafNumber = value;
			}
		}

		public Node<T> this[int i_index]
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

		public HuffmanTree(int i_lefNumber)
		{
			m_data = new Node<T>[2 * i_lefNumber - 1];
			m_leafNumber = i_lefNumber;
		}

		public void Create()
		{
			for(int i = 0; i < m_leafNumber; i++)
			{
				
			}
		}
	}
}
